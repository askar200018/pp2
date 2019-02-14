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
            string s1 , s2;// создаем две строки
            s1 = Console.ReadLine();// считываем первую строку с консоли 
            s2 = Console.ReadLine();// считываем вторую строку
            int n = int.Parse(s1);// первую строку переводим в тип инт
            string[] arr = s2.Split();// вторую строку через функцию парс переводим в массив строк
            List<int> list = new List<int>();// создаем динамический массив чисел
            for(int i = 0; i < n; i++)// пробегаемся циклом от нуля до н не включительно
            {
                for(int j = 0; j < 2; j++)// циклом пробегемся от нуля до 2 не включительно
                {
                    list.Add(int.Parse(arr[i]));// с помощью функции парс переводим строку в число и отправляем в динамический массив
                }
            }
            for(int i = 0; i < list.Count; i++)// пробегаемся по динамическому массиву
            {
                Console.Write(list[i] + " ");// выводим все числа внутри динамического массива
            }

        }
    }
}
