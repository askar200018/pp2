using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Example6
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("clock.txt");
            string s = sr.ReadToEnd();
            sr.Close();
            Console.WriteLine(s);
            //while (true)
            //{
            //    Console.WriteLine("   12   ");
            //    Console.Write("  11");
            //    Console.WriteLine("    1");
            //    Console.Write(" 10");
            //    Console.WriteLine("     2");
            //    Console.Write("9");
            //    Console.WriteLine("      3");
            //    Console.Write(" 8");
            //    Console.WriteLine("     4");
            //    Console.Write(" 10");
            //}
        }
    }
}
