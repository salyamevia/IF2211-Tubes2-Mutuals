using System;
using System.Collections.Generic;
using System.Linq;

namespace e_Handbook
{
    public class Functions
    {
        protected List<string> file = new List<string>();
        Dictionary<string, HashSet<string>> graf = new Dictionary<string, HashSet<string>>();

        public void BacaFile(string location)
        {
            file.Clear();
            int n = Int32.Parse(System.IO.File.ReadLines(location).First());
            string[] data = System.IO.File.ReadAllLines(location);
            data = data.Skip(1).ToArray();
            foreach (string line in data)
            {
                string[] inputs = line.Split(' ');
                string a = inputs[0], b = inputs[1];
                AddGraphIfNotExist(a, b); AddGraphIfNotExist(b, a);
            }
        }

        public List<string> getFile()
        {
            return this.file;
        }

        public void AddGraphIfNotExist(string key, string val)
        {
            if (!this.graf.ContainsKey(key))
            {
                HashSet<string> temp = new HashSet<string>();
                temp.Add(val);
                graf.Add(key, temp);
            }
            else
            {
                graf[key].Add(val);
            }
        }

        public Dictionary<string, HashSet<string>> getGraf()
        {
            return this.graf;
        }

        public Dictionary<String, List<String>> friendRecommendation(string chosenAccount)
        {
            // Node yang sudah dikunjungi;
            Dictionary<string, int> visited = new Dictionary<string, int>();

            // Assign semua node dengan 0 (Belum dikunjungi)
            foreach (var map in graf)
            {
                visited.Add(map.Key, 0);
            }

            // Node a sudah dikunjungi
            visited[chosenAccount] = 1;

            // Pencarian dilakukan hingga depth=2

            HashSet<string> mutual = new HashSet<string>();
            foreach (var val in graf[chosenAccount])
            {
                mutual.Add(val);
            }

            Dictionary<string, int> answer = new Dictionary<string, int>();
            foreach (var val in mutual)
            {
                foreach (var candidate in graf[val])
                {
                    bool ok = true;
                    foreach (var test in graf[chosenAccount])
                    {
                        if (candidate == test || candidate == chosenAccount)
                        {
                            ok = false;
                            break;
                        }
                    }
                    if (ok)
                    {
                        if (!answer.ContainsKey(candidate))
                        {
                            answer.Add(candidate, 0);
                        }
                    }
                }
            }
            foreach (var x in answer.ToList())
            {
                int count = 0;
                foreach (var val in graf[x.Key])
                {
                    foreach (var test in mutual)
                    {
                        if (val == test)
                        {
                            count++;
                        }
                    }
                }
                answer[x.Key] = count;
            }
            // Sorting
            Dictionary<String, List<String>> result = new Dictionary<String, List<String>>();
            foreach (KeyValuePair<string, int> x in answer.OrderByDescending(key => key.Value))
            {
                List<String> mutuals = new List<String>();
                foreach (var val in mutual)
                {
                    foreach (var test in graf[x.Key])
                    {
                        if (val == test)
                        {
                            mutuals.Add(val);
                            break;
                        }
                    }
                }

                result.Add(x.Key, mutuals);

            }

            return result;
        }

        public List<string> exploreFriends(string chosenAccount, string exploreFriendAccount, Boolean useDFS)
        {
            // Mencari jalur yang menghubungkan dua buah node
            List<string> path = new List<string>();

            if (useDFS)
            {
                path = exploreDFS(chosenAccount, exploreFriendAccount);
            }
            else
            {
                path = exploreBFS(chosenAccount, exploreFriendAccount);
            }

            // Return result
            List<String> result = new List<String>();
            if (path.Count <= 1)
            {
                result.Add("Connection\npathway\nnot found.\nYou have to\nstart this\nconnection\nyourself.");
            }
            else
            {
                int i = 0;
                while (i < path.Count)
                {
                    result.Add(path[i]);
                    i++;
                }
            }

            return result;
        }

        public List<string> exploreBFS(string a, string b)
        {
            // Mencari jalur antara a dan b secara BFS
            Queue<Tuple<string, List<string>>> q = new Queue<Tuple<string, List<string>>>();

            bool found = true;

            List<string> FirstPath = new List<string>();

            Tuple<string, List<string>> CurrentVertice = new Tuple<string, List<string>>(a, FirstPath);
            Dictionary<string, int> check = new Dictionary<string, int>();

            // Memasukkan semua vertice ke dalam checker dengan value 0 (belum dikunjungi)
            foreach (var node in graf)
            {
                check.Add(node.Key, 0);
            }

            // Jika belum goal node atau masih ada item queue yang belum dicek
            while (CurrentVertice.Item1 != b && found)
            {
                check[CurrentVertice.Item1] = 1;

                // Masukkan semua adjacent node ke CurrentVertice yang belum dikunjungi
                // Bentuk: tuple (AdjacentNode, PathSoFar -> PathSoFar + CurrentNode)
                foreach (var node in graf[CurrentVertice.Item1])
                {
                    if (check[node] == 0)
                    {
                        List<string> UpdatePath = deepCopyIsh(CurrentVertice.Item2);
                        UpdatePath.Add(CurrentVertice.Item1);
                        Tuple<string, List<string>> tpl = new Tuple<string, List<string>>(node, UpdatePath);
                        q.Enqueue(tpl);
                    }
                }

                // Jika queue sudah kosong, hentikan pencarian, jika belum lanjutkan dengan dequeue()
                if (q.Count == 0)
                {
                    found = false;
                }
                else
                {
                    CurrentVertice = q.Dequeue();
                }
            }

            // Jika tidak ditemukan, reset path menjadi {a}, jika ditemukan, kembalikan path a - b
            if (found == false)
            {
                List<string> path = new List<string>();
                path.Add(a);
                return path;
            }
            else
            {
                List<string> FinalPath = deepCopyIsh(CurrentVertice.Item2);
                FinalPath.Add(CurrentVertice.Item1);
                return FinalPath;
            }
        }

        public List<string> exploreDFS(string a, string b)
        {
            // Mencari jalur antara a dan b secara DFS
            List<string> path = new List<string>();
            path.Add(a);

            bool found = true;
            string CurrentVertice = a;
            Dictionary<string, int> check = new Dictionary<string, int>();

            // Memasukkan semua vertice ke dalam checker dengan value 0 (belum dikunjungi)
            foreach (var node in graf)
            {
                check.Add(node.Key, 0);
            }
            check[a] = 1;

            // Jika belum goal node dan belum backtrack maksimal (kembali ke node a)
            while (CurrentVertice != b && found)
            {
                if (CurrentVertice == a && allNeighborsVisited(CurrentVertice, check))
                {
                    // Jika sudah ke node a dan semua adjacent node sudah diperiksa, hentikan pencarian
                    found = false;
                }
                else if (allNeighborsVisited(CurrentVertice, check))
                {
                    // Jika bukan node a dan semua adjacent node sudah diperiksa, mundur ke node terakhir
                    path.Remove(CurrentVertice);
                    CurrentVertice = path[path.Count - 1];
                }
                else
                {
                    // Jika masih ada adjacent node yang belum diperiksa, pindah ke node tersebut dan tambahkan ke path
                    foreach (var node in graf[CurrentVertice])
                    {
                        if (check[node] != 1)
                        {
                            CurrentVertice = node;
                            check[CurrentVertice] = 1;
                            path.Add(CurrentVertice);
                            break;
                        }
                    }
                }
            }

            return path;
        }

        public bool allNeighborsVisited(string vertice, Dictionary<string, int> check)
        {
            // Memeriksa apabila sudah mengunjungi semua node yang bertetangga dengan vertice
            foreach (var node in graf[vertice])
            {
                if (check[node] == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public List<string> deepCopyIsh(List<string> reference)
        {
            List<string> newList = new List<String>();
            foreach (var val in reference)
            {
                newList.Add(val);
            }
            return newList;
        }
    }
}