using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace task1
{
    class Program
    {
        public static void Palindrome()
        {
            StreamReader sr = new StreamReader("input.txt");
            string s = sr.ReadLine();
            int count = 0;
            for (int i = 0; i < s.Length / 2 ; i++)
            {
                if (s[i] != s[s.Length - i - 1])
                {
                    count++;
                    break;
                }
            }
            if (count >= 1)
            {
                Console.WriteLine("No");
            }
            else Console.WriteLine("Yes");
            sr.Close();
        } 
        static void Main(string[] args)
        {
            Palindrome();
        }
    }
}
