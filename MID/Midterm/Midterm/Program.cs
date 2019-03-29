using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Midterm
{
    class Football
    {
        public Team firstteam;
        public Team secondteam;
        public string stadium;
        public Person referee;
        public Football() { }
        public Football(Team firstteam , Team secondteam , string stadium , Person referee)
        {
            this.firstteam = firstteam;
            this.secondteam = secondteam;
            this.stadium = stadium;
            this.referee = referee;
        }
    }
    class Team
    {
        public List<Person> players;
        public string Name;
        public Person coach;
        public Team() { }
        public Team(List<Person> players , string Name , Person coach)
        {
            this.players = players;
            this.Name = Name;
            this.coach = coach;
        }
    }
    class Person
    {
        public string Name;
        public int age;
        public string country;
        public Person() { }
        public Person(string Name , int age , string country)
        {
            this.Name = Name;
            this.age = age;
            this.country = country;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Alexey", 19, "Kz");
            Person person2 = new Person("Arman", 18, "KZ");
            Person coach = new Person("Coach", 29, "KZ");
            List<Person> players = new List<Person>();
            players.Add(person);
            players.Add(person2);
            Team team1 = new Team(players, "Foot", coach);
            Person p1 = new Person("Alexey2", 19, "Kz");
            Person p2 = new Person("Arman2", 18, "KZ");
            Person c2 = new Person("Coach2", 29, "KZ");
            List<Person> players2 = new List<Person>();
            players.Add(p1);
            players.Add(p2);
            Team team2 = new Team(players2, "Foot2", c2);
            Person referee = new Person("REF", 34, "RUS");
            Football football = new Football(team1, team2, "Wim", referee);
            FileStream fs = new FileStream("FOOTBALL.xml", FileMode.Create, FileAccess.Write);
            XmlSerializer xs = new XmlSerializer(typeof(Football));
            xs.Serialize(fs, football);
            fs.Close();
            Console.ReadKey();
        }
    }
}
