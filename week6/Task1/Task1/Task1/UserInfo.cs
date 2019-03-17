using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class UserInfo
    {
        public string name;
        public int score;
        public int level;
        public UserInfo() { }
        public UserInfo(string name, int score , int level)
        {
            this.name = name;
            this.score = score;
            this.level = level;
        }
        public void PrintInfo()
        {
            Console.SetCursorPosition(21, 20);
            Console.Write("Your name : {0}", name);
            Console.SetCursorPosition(0, 21);
            Console.Write("Your score : {0}", score);
            Console.SetCursorPosition(0, 22);
            Console.Write("Your level : {0}", level);
            Console.SetCursorPosition(0, 23);
            Console.Write("Press TAB to pause game !");
        }
    }
}
