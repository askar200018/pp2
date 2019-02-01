using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    

    class Program
    {

        public static bool isprime(int a)
        {
            if (a == 1) return false;
            for(int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            int n = int.Parse(a);
            string s1 = Console.ReadLine();
            string[] arr = s1.Split();
            int[] arr2 = new int[1000];
            int cou = 0;
            for(int i = 0; i < n; i++)
            {
                arr2[i] = int.Parse(arr[i]);
            }
            for(int i = 0; i < n; i++)
            {
                if (isprime(arr2[i]) == false)
                {
                    arr2[i] = 0;
                }
                else cou++;
            }
            Console.WriteLine(cou);
            for(int i = 0; i < n; i++)
            {
                if(arr2[i] != 0 )
                Console.Write(arr2[i] + " ");
            } 
        }
    }
}
