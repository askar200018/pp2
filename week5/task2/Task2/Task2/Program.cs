using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;



namespace Task2
{
    public class Mark
    {
        public int a;
        public string letter;
        public Mark() { }
        public Mark(int a)
        {
            this.a = a;
            this.getLetter();
        }
        public void getLetter()
        {
            if (a < 100 && a >= 95) letter = "A";
            else if (a < 95 && a >= 90) letter = "A-";
            else if (a < 90 && a >= 85) letter = "B+";
            else if (a < 85 && a >= 80) letter = "B";
            else if (a < 80 && a >= 75) letter = "B-";
            else if (a < 75 && a >= 70) letter = "C+";
            else if (a < 70 && a >= 65) letter = "C";
            else if (a < 65 && a >= 60) letter = "C-";
            else if (a < 60 && a >= 55) letter = "D+";
            else if (a < 55 && a >= 50) letter = "D";
            else if (a < 50) letter = "F";
        }
        public override string ToString()
        {
            return a + " " + letter;
        }
    }
    public class ListOfMarks
    {
        public List<Mark> listOfMarks;
        //public ListOfMarks() { }
        public ListOfMarks()
        {
            listOfMarks = new List<Mark>();
        }
        public void Save(ListOfMarks listOfMarks)
        {
            FileStream fs = new FileStream("marks.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xm = new XmlSerializer(typeof(ListOfMarks));
            xm.Serialize(fs, listOfMarks);
            fs.Close();
        }
        
    }
    class Program
    {
        public static void F1()
        {
            Mark st1 = new Mark(97);
            Mark st2 = new Mark(85);
            Mark st3 = new Mark(73);
            ListOfMarks list = new ListOfMarks();
            list.listOfMarks.Add(st1);
            list.listOfMarks.Add(st2);
            list.listOfMarks.Add(st3);
            list.Save(list);
        }
        public static void F2()
        {
            FileStream fs = new FileStream("marks.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            XmlSerializer xs = new XmlSerializer(typeof(ListOfMarks));
            ListOfMarks list = xs.Deserialize(fs) as ListOfMarks;
            fs.Close();
            foreach(Mark m in list.listOfMarks)
            {
                Console.WriteLine(m);
            }
        }
        static void Main(string[] args)
        {
            F1();
            F2();
        }
    }
}
