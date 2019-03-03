using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Student
    {
        public string name;//имя студента
        public string id;//айди
        public int year = 1;//год обучения первый

        public Student(string name , string id)// конструктор студент
        {
            this.name = name;// имя которое передали становится именем в классе
            this.id = id;// с айди тоже самое
        }
        public void print()//функция принт
        {
            year += 1;// увеличиваем год на 1
            Console.WriteLine(name + " " + id + " " + year);//печатаем имя , айди , и год обучения
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("Askar", "18BD110715");// передаем данные конструктору
            st1.print();//вызывает функцию принт для печати
        }
    }
}
