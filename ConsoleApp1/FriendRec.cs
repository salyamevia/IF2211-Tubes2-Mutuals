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

    public void exploreFriends()
    {
        // Mencari jalur yang menghubungkan dua buah node
        Console.Write("Akun pertama: ");
        string a = Console.ReadLine();
        Console.Write("Akun kedua: ");
        string b = Console.ReadLine();

        Console.WriteLine("\nPilih metode pencarian, masukkan angka:");
        Console.WriteLine("  1. BFS");
        Console.WriteLine("  2. DFS");

        string choice = "0";

        while (choice != "1" && choice != "2")
        {
            Console.Write("Pilihan anda: ");
            choice = Console.ReadLine();
        }

        List<string> path = new List<string>();

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
            Console.WriteLine("Jalur koneksi antara " + a + " dan " + b + " adalah " + (path.Count - 1) + "-degree connection dengan path:");
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
