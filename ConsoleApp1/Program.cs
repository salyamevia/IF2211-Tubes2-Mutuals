using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {
            Functions x=new Functions();
            int n = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                string[] inputs = input.Split(' ');
                string a = inputs[0], b = inputs[1];
                x.AddGraphIfNotExist(a,b);x.AddGraphIfNotExist(b,a);
                
            }
            Console.WriteLine("Representasi Graph: ");
            foreach(var map in x.getGraf())
            {
                Console.Write(map.Key + "| ");
                foreach(var vals in map.Value)
                {
                    Console.Write(vals+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("FriendRecommendation: ");
            Console.Write("Nama yang akan dicari rekomendasinya: ");
            x.FriendExplore();

        }
    }
}
