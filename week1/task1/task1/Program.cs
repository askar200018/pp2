using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    

    class Program
    {

        public static bool isprime(int a)// создаем булевую функцию для проверки простых чисел 
        {
            if (a == 1) return false;// если число равно единице то оно не простое и мы возвращаем фолс
            for(int i = 2; i <= Math.Sqrt(a); i++)// пробегаемся от 2 до корня самого числа 
            {
                if (a % i == 0) return false;// если оно делится на число от 2 до корня самого число то это число не простое и мы возвращаем фолс
            }
            return true;// если число успешно вышла с цикла значит число простое и мы возвращаем тру
        }

        static void Main(string[] args)
        {
            string a = Console.ReadLine();// считываем строку
            int n = int.Parse(a);// переводим строку в тип инт
            string s1 = Console.ReadLine(); // считываем вторукю строку
            string[] arr = s1.Split();// вызываем функцию сплит и переводим строку в массив строк через пробелы
            int[] arr2 = new int[1000];// создаем массив чисел
            int cou = 0;// счетчик для простых чисел 
            for(int i = 0; i < n; i++)// создаем цикл чтобы перевести числа из массива строк в массив чисел
            {
                arr2[i] = int.Parse(arr[i]);
            }
            for(int i = 0; i < n; i++)
            {
                if (isprime(arr2[i]) == false)// отправляем каждое число в функцию isprime и проверяем
                {
                    arr2[i] = 0;// если число не простое то мы его значение меняем на нуль 
                }
                else cou++;// если число простое то мы увелилчиваем счетчик
            }
            Console.WriteLine(cou);// показывем сколькое есть простых чисел
            for(int i = 0; i < n; i++)
            {
                if(arr2[i] != 0 ) // если число в массиве не равно нулю мы его выводим
                Console.Write(arr2[i] + " ");
            } 
        }
    }
}
