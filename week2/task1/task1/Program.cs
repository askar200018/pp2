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
        public bool polin(string a)
        {
            for(int i = 0; i < a.Length/2; i++)
            {
                if (a[i] != a[a.Length - i - 1]) return false;
            }
            return true;
        }
        public static void Palindrome()
        {
            StreamReader sr = new StreamReader("input.txt");// создаем стримридер и указывем путь
            string s = sr.ReadLine();//считываем строку с файла и отрпавляем в стринг
            int count = 0;//нужен для проверки палиндрома
            for (int i = 0; i < s.Length / 2 ; i++)//пробегаемся до половины слова
            {
                if (s[i] != s[s.Length - i - 1])//проверяем первую букву и последнюю(+1 к первому и -1 к последнему)
                {
                    count++;//если буквы разные то счетчик увеличивается
                    break;//выходим из цикла
                }
            }
            if (count >= 1)//если число больше или равно 1
            {
                Console.WriteLine("No");//значит он не полиндром
            }
            else Console.WriteLine("Yes");//иначе полиндром
            sr.Close();//
        } 
        static void Main(string[] args)
        {
            Palindrome();//вызываем функцию палиндром
        }
    }
}
