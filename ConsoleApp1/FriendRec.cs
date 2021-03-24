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
}
