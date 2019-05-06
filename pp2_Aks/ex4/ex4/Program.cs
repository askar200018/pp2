using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex4
{
    class Program
    {
        static void Main(string[] args)
        {
                List<int> list = new List<int>();
                list.Add(1);
                list.Add(2);
                list.Add(12);
                for (int i = 0; i < list.Count; i++)
                    Console.WriteLine(list[i]);

                //int[] a = new int[3];
                //a[0] = 1;
                //a[1] = 2;
                //a[2] = 3;
                //for (int i = 0; i < a.Length; i++)
                //Console.WriteLine(a[i]);

                //int[,] a = new int[10, 10];
                //for (int i = 0; i < 10; i++)
                //    for (int j = 0; j < 10; j++)
                //        a[i, j] = i * j;

                //for (int i = 0; i < 10; i++)
                //{
                //    for (int j = 0; j < 10; j++)
                //        Console.Write(a[i, j] + " ");
                //    Console.WriteLine();
                //}
            }
        }
    }
