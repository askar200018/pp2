using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class EndGame
    {
        public string Name;
        public EndGame() { }
        public EndGame( string Name)
        {
            this.Name = Name;
        }
        public void Choice()
        {
            Console.CursorVisible = false;
            Console.SetCursorPosition(30, 10);
            Console.WriteLine("GAME OVER");
            Console.WriteLine("Press R to reset game");
            Console.WriteLine("Press ESC to quit game");
            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.Key == ConsoleKey.Escape)
                Console.WriteLine(" See you next time");
            if (keyInfo.Key == ConsoleKey.R)
            {
                Game game = new Game(new UserInfo(Name, 0, 0));
                game.Start();
            }
        }
    }
}
