using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication7
{
    class Program
    {
        static void Main(string[] args)
        {
            //c)
            int[][] numbers = new int[3][];
            numbers[0] = new int[] { 1, 2 };
            numbers[1] = new int[] { 1, 2, 3 };
            numbers[2] = new int[] { 1, 2, 3, 4 };
            for (int z = 0; z < numbers.Length; z++)
            {
                for (int f = 0; f < numbers[z].Length; f++)
                {
                    Console.Write($"{numbers[z][f]} \t");
                }
                Console.WriteLine();
            }

            //d)

            var a = new[] { 1, 10, 100, 1000 }; // int[] 

            var b = new[] { "Привет, " , "мир!" }; // string[] 

            //3)
            //a)

            
        }
        
    }

}
