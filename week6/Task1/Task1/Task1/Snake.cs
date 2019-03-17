using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Snake : GameObject
    {
        enum Direction
        {
            DOWN ,
            UP,
            LEFT,
            RIGHT, 
            NONE
        }
        Direction direction = Direction.NONE;
        public Snake(int x, int y, char sign, ConsoleColor color): base(x , y , sign , color)
        {
            
        }
        public void Move()
        {
            if (direction == Direction.NONE)
                return;

            for (int i = body.Count - 1; i > 0; i--)
            {
                body[i].x = body[i - 1].x;
                body[i].y = body[i - 1].y;
            }
            if (direction == Direction.UP)
                body[0].y--;
            if (direction == Direction.DOWN)
                body[0].y++;
            if (direction == Direction.LEFT)
                body[0].x--;
            if (direction == Direction.RIGHT)
                body[0].x++;
        }

        public void ChangeDirection(ConsoleKeyInfo keyInfo)
        {
            if (body.Count <= 1)
            {
                if (keyInfo.Key == ConsoleKey.DownArrow)
                    direction = Direction.DOWN;
                if (keyInfo.Key == ConsoleKey.UpArrow)
                    direction = Direction.UP;
                if (keyInfo.Key == ConsoleKey.LeftArrow)
                    direction = Direction.LEFT;
                if (keyInfo.Key == ConsoleKey.RightArrow)
                    direction = Direction.RIGHT;
            }
            else
            {
                if (keyInfo.Key == ConsoleKey.DownArrow && direction != Direction.UP)
                    direction = Direction.DOWN;
                if (keyInfo.Key == ConsoleKey.UpArrow && direction != Direction.DOWN)
                    direction = Direction.UP;
                if (keyInfo.Key == ConsoleKey.LeftArrow && direction != Direction.RIGHT)
                    direction = Direction.LEFT;
                if (keyInfo.Key == ConsoleKey.RightArrow && direction != Direction.LEFT)
                    direction = Direction.RIGHT;
            }
        }

        public bool IsCollisionWithFood(Food food)
        {
            if (body[0].x == food.body[0].x && body[0].y == food.body[0].y)
                return true;
            return false;
        }
        public bool IsCollistionWithWall(Wall wall)
        {
            foreach (Point p in wall.body)
            {
                if (p.x == body[0].x && p.y == body[0].y)
                    return true;
            }
            return false;
        }

        public bool IsCollisionWithSnake()
        {
            for (int i = 1; i < body.Count; i++)
                if (body[0].x == body[i].x && body[0].y == body[i].y)
                    return true;
            return false;
        }
    }
}
