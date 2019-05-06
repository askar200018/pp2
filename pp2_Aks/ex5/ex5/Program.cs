using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5
{
    class Student

    {

        public string name;

        public string surname;

        public double gpa;



        public Student()
        {

            name = Console.ReadLine();

            surname = Console.ReadLine();

            gpa = double.Parse(Console.ReadLine());

        }



        public Student(string name, string surname)

        {

            this.name = name;

            this.surname = surname;

        }



        public Student(string name, string surname, double gpa)

        {

            this.name = name;

            this.surname = surname;

            this.gpa = gpa;

        }



        //public void Init(string name, string surname, double gpa)

        //{

        //    this.name = name;

        //    this.surname = surname;

        //    this.gpa = gpa;

        //}



        //public void Print()

        //{

        //    Console.WriteLine(name + " " + surname + " " + gpa);

        //}



        public override string ToString()

        {

            return name + " " + surname + " " + gpa;

        }

    }



    class Program

    {

        static void Main(string[] args)

        {

            Student st1 = new Student("aaa", "bbb", 3.0);

            //st1.Init("aaa", "bbb", 3.0);



            Student st2 = new Student("qqq", "ccc");

            st2.gpa = 3.2;



            Student st3 = new Student();

            //st1.Print();

            //st2.Print();

            Console.WriteLine(st1);

            Console.WriteLine(st2);

            Console.WriteLine(st3);



        }

    }
}
