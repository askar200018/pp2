using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string s1 , s2;
            s1 = Console.ReadLine();
            s2 = Console.ReadLine();
            int n = int.Parse(s1);
            string[] arr = s2.Split();
            int[] arr2 = new int[1000];
            for(int i = 0; i < n; i++)
            {
                arr2[i] = int.Parse(arr[i]);
            }
            for(int i = 0; i < n; i++)
            {
                Console.Write(arr2[i] + " " + arr2[i] + " ");
            }

        }
    }
}
