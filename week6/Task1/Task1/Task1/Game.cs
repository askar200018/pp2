using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Task1
{
    [Serializable]
    class Game
    {
        public Snake snake;
        public Food food;
        public Wall wall;
        bool isAlive;
        public UserInfo userInfo;
        List<GameObject> g_objects;
        public Game(UserInfo userInfo)
        {
            this.userInfo = userInfo;
            isAlive = true;
            snake = new Snake(10, 10, '*', ConsoleColor.Red);
            food = new Food(0, 0, '@', ConsoleColor.Blue);
            wall = new Wall('#', ConsoleColor.Yellow);
            wall.LoadLevel();
            food.Generate(snake , wall);

            g_objects = new List<GameObject>();
            g_objects.Add(snake);
            g_objects.Add(food);
            g_objects.Add(wall);
            Console.CursorVisible = false;
        }
        public void Start()
        {
            //ConsoleKeyInfo keyInfo = Console.ReadKey();

            Thread thread = new Thread(MoveSnake);
            thread.Start();
            ConsoleKeyInfo keyInfo = Console.ReadKey();

            while (keyInfo.Key != ConsoleKey.Escape && isAlive)
            {               
                keyInfo = Console.ReadKey();
                if(keyInfo.Key == ConsoleKey.Tab)
                {
                    //Save(this);
                    Pause();
                    break;
                }
                else snake.ChangeDirection(keyInfo);
            }
            Console.Clear();
            EndGame endgame = new EndGame(userInfo.name);
            endgame.Choice();
        }
        public void MoveSnake()
        {
            while (isAlive)
            {
                snake.Move();
                if (snake.IsCollisionWithFood(food))
                {
                    userInfo.score += 10;
                    snake.body.Add(new Point(0, 0, '*'));
                    food.Generate(snake, wall);
                    if (userInfo.score % 40 == 0)
                    {
                        wall.NextLevel();
                        userInfo.level++;
                    }
                }
                if (snake.IsCollistionWithWall(wall))
                {
                    isAlive = false;
                    break;
                }
                if (snake.IsCollisionWithSnake())
                {
                    isAlive = false;
                    break;
                }
                Draw();
                Thread.Sleep(200);
            }
            //Console.Clear();
            //EndGame endgame = new EndGame(userInfo.name);
            //endgame.Choice();
        }
        public void Draw()
        {
            Console.Clear();
            Console.SetWindowSize(80, 25);
            Console.SetBufferSize(80, 25);
            userInfo.PrintInfo();
            foreach (GameObject g in g_objects)
            {
                g.Draw();
            }
        }
        public void Save(Game g)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream("game.bin", FileMode.Create, FileAccess.Write);
            binaryFormatter.Serialize(fileStream, g);
            fileStream.Close();
        }
        public void Pause()
        {
            Console.Clear();
            Console.SetCursorPosition(21, 20);
            Console.WriteLine("Press C to continue game ");
            Console.WriteLine("Press E to end game");
            //ConsoleKeyInfo keyInfo = Console.ReadKey();
            //if(keyInfo.Key == ConsoleKey.C)
            //{
            //    DeSer().Start();
            //}
            //else if(keyInfo.Key == ConsoleKey.E)
            //{
            //    Console.Clear();
            //    Console.SetCursorPosition(21, 20);
            //    Console.WriteLine("GAME OVER");
            //}

        }
        public Game DeSer()
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            FileStream fileStream = new FileStream("game.bin", FileMode.Open, FileAccess.Read);
            Game g = binaryFormatter.Deserialize(fileStream) as Game;
            fileStream.Close();
            return g;
        }
        public void ShowMenu()
        {

        }
    }
}
