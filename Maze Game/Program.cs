using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] cells = new int[5, 6];
            int[,] right = new int[5, 6];
            int[,] left = new int[5, 6];
            int[,] top= new int[5, 6];
            int[,] bottom= new int[5, 6];
            cells[2, 0] = 1;
            cells[4, 1] = 1;
            cells[1, 2] = 1;
            cells[3, 3] = 1;
            cells[0, 5] = 1;

            top[1, 0] = 1;
            bottom[0, 0] = 1;

            top[4, 0] = 1;
            bottom[3, 0] = 1;

            top[3, 1] = 1;
            bottom[2, 1] = 1;

            top[3, 2] = 1;
            bottom[2, 2] = 1;

            top[4, 4] = 1;
            bottom[3, 4] = 1;

            right[3,0]= 1;
            left[3,1]= 1;

            right[0, 1] = 1;
            left[0, 2] = 1;

            right[2, 3] = 1;
            left[2, 4] = 1;

            right[0, 4] = 1;
            left[0, 5] = 1;

            right[2, 4] = 1;
            left[2, 5] = 1;

            Grid mygrid = new Grid(5, 6, cells, right, left, top, bottom);
            Maze_Game mygame = new Maze_Game(mygrid);
            

            while(mygame.lives>=0)
            {
                
                Console.WriteLine("Current Position:\nI:" + mygame.cur_loc.I + "\nJ:" + mygame.cur_loc.J);
                Console.WriteLine("lives:" + mygame.lives);
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.RightArrow)
                {
                    Console.Clear();
                    mygame.Tilt(Maze_Game.Direction.right);
                }

                if (key.Key == ConsoleKey.LeftArrow)
                {
                    Console.Clear();
                    mygame.Tilt(Maze_Game.Direction.left);
                }

                if (key.Key == ConsoleKey.UpArrow)
                {
                    Console.Clear();
                    mygame.Tilt(Maze_Game.Direction.up);
                }

                if (key.Key == ConsoleKey.DownArrow)
                {
                    Console.Clear();
                    mygame.Tilt(Maze_Game.Direction.down);
                }
            }
            Console.ReadLine();

        }
    }
}
