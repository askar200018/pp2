using System;
using System.IO;
using System.Xml.Serialization;

namespace Task1
{
    public class ComplexNumber
    {
        public double x;
        public double y;
        public string s;
        public ComplexNumber() { }
        public ComplexNumber(double x , double y)
        {
            this.x = x;
            this.y = y;
            this.s = x + "+" + y + 'i';
        }        public override string ToString()
        {
            return s;
        }
    }
    class Program
    {
        public static void Ser()
        {
            ComplexNumber comnum = new ComplexNumber(4.5, 9.6);
            FileStream fs1 = new FileStream("complex.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(ComplexNumber));
            xs.Serialize(fs1, comnum);
            fs1.Close();
        }
        public static void F2()
        {
            FileStream fs = new FileStream("complex.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(ComplexNumber));
            ComplexNumber comnum = xs.Deserialize(fs) as ComplexNumber;
            fs.Close();
            Console.WriteLine(comnum);
        }
        static void Main(string[] args)
        {
            Ser();
            F2();
        }
    }
}
