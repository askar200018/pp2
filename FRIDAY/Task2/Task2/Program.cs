using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Xml.Serialization;


namespace Task2
{
    class Employee
    {
        public string Name;
        public int Wage;
        List<Employee> employees;
        public Employee() { }
        public Employee(string Name , int Wage)
        {
            this.Name = Name;
            this.Wage = Wage;
            employees.Add(this);
        }
        public void ShowAll()
        {
            Console.WriteLine("EMPLOYEE : {0} and WAGE : {1}", Name, Wage);

            FileStream fs = new FileStream("em.xml", FileMode.OpenOrCreate, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(Employee));
            xs.Serialize(fs, employees);
            fs.Close();
        }
        public void AddedNew()
        {
            string s = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            Employee employee = new Employee(s, n);
            employees.Add(employee);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee("Jjjs", 899);
            Employee employee2 = new Employee("Jjjdffs", 8959);
            Employee employee3 = new Employee("Jjjsdf", 8996);
            List<Employee> employees = new List<Employee>();
            employees.Add(employee);
            employees.Add(employee2);
            employees.Add(employee3);
            for(int i = 0; i < 3; i++)
            {
                employees[i].ShowAll();
            }
            employees[0].AddedNew();
        }
    }
}
