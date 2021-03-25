using System;
using System.Collections.Generic;
using System.Linq;

public class Functions
{
	protected List<string> file = new List<string>();
    Dictionary<string,HashSet<string>> graf = new Dictionary<string, HashSet<string>>();

	public void BacaFile(string location)
    {
        file.Clear();
        string[] data = System.IO.File.ReadAllLines(location);
        foreach(string line in data)
        {
            file.Add(line);
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

    public void FriendExplore()
    {
        string a = Console.ReadLine();
        // Node yang sudah dikunjungi;
        Dictionary<string, int> visited = new Dictionary<string, int>();
        
        // Assign semua node dengan 0 (Belum dikunjungi)
        foreach(var map in graf)
        {
            visited.Add(map.Key, 0);
        }

        // Node a sudah dikunjungi
        visited[a] = 1;

        // Pencarian dilakukan hingga depth=2

        HashSet<string> mutual = new HashSet<string>();
        foreach (var val in graf[a])
        {
            mutual.Add(val);
        }

        Dictionary<string, int> answer = new Dictionary<string, int>();
        foreach (var val in mutual)
        {
            foreach(var candidate in graf[val])
            {
                bool ok = true;
                foreach(var test in graf[a])
                {
                    if(candidate==test || candidate == a)
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
        foreach (var x in answer)
        {
            int count = 0;
            foreach (var val in graf[x.Key])
            {
                foreach(var test in mutual)
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
        foreach (KeyValuePair<string, int> x in answer.OrderByDescending(key => key.Value))
        {
            Console.Write("Nama akun: ");
            Console.WriteLine(x.Key);
            Console.WriteLine(x.Value + " mutual friends:");
            foreach(var val in mutual)
            {
                foreach(var test in graf[x.Key])
                {
                    if (val == test)
                    {
                        Console.WriteLine(val);
                        break;
                    }
                }
            }
            Console.WriteLine();
        }
    }

    public void exploreFriends()
    {
        // Mencari jalur yang menghubungkan dua buah node
        // Implement checker for a and b validity?
        Console.Write("Akun pertama: ");
        string a = Console.ReadLine();
        Console.Write("Akun kedua: ");
        string b = Console.ReadLine();

        Console.WriteLine("\nPilih metode pencarian, masukkan angka:");
        Console.WriteLine("  1. BFS");
        Console.WriteLine("  2. DFS");

        string choice = "0";

        while (choice != "1" || choice != "2")
        {
            Console.Write("Pilihan anda: ");
            string choice = Console.ReadLine();
        }

        HashSet<string> path = new HashSet<string>();

        if (choice == "1")
        {
            path = exploreBFS(a, b);
        }
        else
        {
            path = exploreDFS(a, b);
        }

        // Print result
        if (path.Count <= 1)
        {
            Console.WriteLine("Tidak ada jalur koneksi yang tersedia.");
            Console.WriteLine("Anda harus memulai koneksi baru itu sendiri.");
        }
        else
        {
            Console.WriteLine("Jalur koneksi antara " + a + " dan " + b + " adalah " + (path.Count - 1) + "th degree connection dengan path:");
            int i = 0;
            while (i < path.Count - 1)
            {
                Console.Write(path[i]);
                Console.Write(" -> ");
                i++;
            }
            Console.WriteLine(path[i] + "\n");
        }
    }

    public HashSet<string> exploreBFS(string a, string b)
    {
        // Mencari jalur antara a dan b secara BFS
        Queue<Tuple<string, HashSet<string>>> q = new Queue<Tuple<string, HashSet<string>>>();

	    bool found = true;
	    Tuple<string, HashSet<string>> CurrentVertice = new Tuple<string, HashSet<string>>();
        CurrentVertice.Item1 = a;
        CurrentVertice.Item2.Add(a);
	    Dictionary<string, int> check = new Dictionary<string, int>();

        // Memasukkan semua vertice ke dalam checker dengan value 0 (belum dikunjungi)
	    foreach (var node in graf)
        {
		    check.Add(node.Key, 0);
	    }

        // Jika belum goal node atau masih ada item queue yang belum dicek
	    while (CurrentVertice.Item1 != b && found)
        {
            check[CurrentVertice] = 1;

            // Masukkan semua adjacent node ke CurrentVertice yang belum dikunjungi
            // Bentuk: tuple (AdjacentNode, PathSoFar -> PathSoFar + CurrentNode)
            foreach (var node in graf[CurrentVertice])
            {
                if (check[node] == 0)
                {
                    Tuple<string, HashSet<string>> tpl = new Tuple<string, HashSet<string>>(node, CurrentVertice.Item2.Add(CurrentVertice.Item1));
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
            HashSet<string> path = new HashSet<string>();
            path.Add(a);
            return path;
        }
        else
        {
            return CurrentVertice.Item2.Add(CurrentVertice);
        }
    }

    public HashSet<string> exploreDFS(string a, string b)
    {
        // Mencari jalur antara a dan b secara DFS
        HashSet<string> path = new HashSet<string>();

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
                foreach (var node in graf)
                {
                    if (check[node.Key] != 1)
                    {
                        CurrentVertice = node.Key;
                        check[CurrentVertice] = 1;
                        path.Add(CurrentVertice);
                        break;
                    }
                }
            }
        }

        return path;
    }

    public bool allNeighborsVisited (string vertice, Dictionary<string, int> check)
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
}
