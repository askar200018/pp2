using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    class Student
    {
        public string name;
        public string id;
        public int year = 1;

        public Student(string name , string id)
        {
            this.name = name;
            this.id = id;
        }
        public void print()
        {
            year += 1;
            Console.WriteLine(name + " " + id + " " + year);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Student st1 = new Student("Askar", "18BD110715");
            st1.print();
        }
    }
}
