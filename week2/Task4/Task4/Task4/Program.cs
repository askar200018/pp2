using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string FilePath1 = @"C:\Users\Аскар\Documents\pp2_Aks\path\output1.txt";
            string FilePath2 = @"C:\Users\Аскар\Documents\pp2_Aks\path\output2.txt";
            StreamWriter sw = new StreamWriter(FilePath1);
            sw.WriteLine("random string");
            sw.Close();
            File.Copy(FilePath1, FilePath2);
            File.Delete(FilePath1);

        }
    }
}
