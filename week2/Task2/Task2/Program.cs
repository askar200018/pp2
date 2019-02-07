using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task2
{
    class Program
    {
        public static bool isprime(int a)
        {
            if (a == 1) return false;
            for (int i = 2; i <= Math.Sqrt(a); i++)
            {
                if (a % i == 0) return false;
            }
            return true;
        }
        static void Prime()
        {
            StreamReader sr = new StreamReader("input.txt");
            string[] arr = sr.ReadLine().Split();
            StreamWriter sw = new StreamWriter("output.txt");
            int[] arr2 = new int[1000];
            for (int i = 0; i < arr.Length; i++)
            {
                if(isprime(int.Parse(arr[i])) == true)
                {
                    sw.Write(int.Parse(arr[i]) + " ");
                }
            }
            sr.Close();
            sw.Close();
        }
        static void Main(string[] args)
        {
            Prime();
        }
    }
}
