using System;
using System.Collections.Generic;

namespace Tubes
{
    class Program
    {
        static void Main(string[] args)
        {
            Functions x = new Functions();
            string loc = @"C:\Users\ghall\Desktop\IF2211-Tubes2-Mutuals\Test\test1.txt";      //  Tinggal ganti dirnya
            x.BacaFile(loc);
            List<string> file = x.getFile();
            int n = Convert.ToInt32(file[0]);
            file.RemoveAt(0);
            for (int i = 0; i < n; i++)
            {
                string input = file[0];
                file.RemoveAt(0);
                string[] inputs = input.Split(' ');
                string a = inputs[0], b = inputs[1];
                x.AddGraphIfNotExist(a, b); x.AddGraphIfNotExist(b, a);

            }
            Console.WriteLine("Representasi Graph: ");
            foreach (var map in x.getGraf())
            {
                Console.Write(map.Key + "| ");
                foreach (var vals in map.Value)
                {
                    Console.Write(vals + " ");
                }
                Console.WriteLine();
            }
            int z=1;
            while (z!=0)
            {
                Console.WriteLine("1. Friend Reccomendation");
                Console.WriteLine("2. Explore Friends");
                Console.WriteLine("0. Exit");
                z = Convert.ToInt32(Console.ReadLine());
                if (z == 1)
                {
                    Console.Write("Input akun yang akan dicari Friend Recommendationnya: ");
                    x.FriendExplore();
                }
                if (z == 2)
                {
                    x.exploreFriends();
                }
            }
        }
    }
}
