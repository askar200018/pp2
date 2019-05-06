using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("Clock.txt");
            string s = sr.ReadToEnd();
            //Console.Write(s);
            sr.Close();
            for(int i =0; i < s.Length; i++)
            {
                //Console.Write(s);
                if (s[i] != ' ')
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(s[i]);
                    Thread.Sleep(300);
                    Console.Clear();
                }
            }
            Console.ReadKey();
        }
    }
}
