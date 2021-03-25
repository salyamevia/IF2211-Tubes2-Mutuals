using System;
using System.Collections.Generic;

public class DFS
{
	public void dfs(Dictionary<string, HashSet<string>> graf)
	{
        // Inisialisasi
        Dictionary<string, bool> visited = new Dictionary<string, bool>();
        foreach (var map in graf)
        {
            visited.Add(map.Key, false);
        }

        // Memanggil fungsi helper rekursif
        foreach (node in graf)
        {
            Console.Write(node.Key)
            Console.Write(node.Value)
        }
	}

}
