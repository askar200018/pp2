using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name ?");
            string Name = Console.ReadLine();
            Console.WriteLine("Hello : {0}", Name);
            UserInfo userinfo = new UserInfo(Name, 0 , 1);
            Game game = new Game(userinfo);
            game.Start();
        }
    }
}
