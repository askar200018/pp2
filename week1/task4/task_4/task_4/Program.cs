using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 = Console.ReadLine();
            int n = int.Parse(s1);
            for(int  i = 0; i < n; i++)
            {
                for(int j = 0; j <= i; j++)
                {
                    Console.Write("[*]");
                }
                Console.WriteLine();
            }
        }
    }
}
