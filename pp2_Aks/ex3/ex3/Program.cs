using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex3
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1,2,6,12,100

            string[] arr = Console.ReadLine().Split(',');

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)

            {

                sum += int.Parse(arr[i]);

            }

            Console.WriteLine(sum);

            //Console.Write("name: {1}, surname:{0} - {1}", "Askar", "Akshabayev");
        }
    }
}
