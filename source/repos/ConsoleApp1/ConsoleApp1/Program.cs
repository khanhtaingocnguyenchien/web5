using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Create Data
            int[] Num = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
            //Query
            IEnumerable<int> SoNum = from a in Num
                                     where a%2==0
                                     select a;
            //Excute
            foreach (int item in SoNum) { 
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
