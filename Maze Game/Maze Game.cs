using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    class Maze_Game
    {
        public Location cur_loc;
        Grid grid;
        int Lives = 3;
        public enum Direction { right, left, up, down};     
        public Maze_Game(Grid g)
        {
            cur_loc = new Location();
            grid = g;
        }

        public int lives
        {
            get { return Lives; }
        }
        public void Tilt(Direction dir) //0: tilt right | 1: tilt left | 2: tilt up | 3: tilt down
        {
            int temp_i=cur_loc.I;
            int temp_j = cur_loc.J;
            
            if(dir==Direction.right) //tilt right
            {
                while(grid.Cells[temp_i,temp_j]!=1 && grid.Right[temp_i, temp_j] != 1 && temp_j<grid.N-1) //if it's not hole, keep going right
                {
                    temp_j++;
                }
                if(grid.Cells[temp_i, temp_j] == 1)
                {
                    Lost();// you are lost. decrease a life.
                    return;
                }
            }
            
            if(dir==Direction.left) //tilt left
            {
                while (grid.Cells[temp_i, temp_j] != 1 && grid.Left[temp_i, temp_j] != 1 && temp_j > 0) //if it's not hole, keep going left
                {
                    temp_j--;
                }
                if (grid.Cells[temp_i, temp_j] == 1)
                {
                    Lost();// you are lost. decrease a life.
                    return;
                }
            }

            if (dir == Direction.up)//tilt left
            {
                while (grid.Cells[temp_i, temp_j] != 1 && grid.Top[temp_i, temp_j] != 1 && temp_i > 0) //if it's not hole, keep going up
                {
                    temp_i--;
                }
                if (grid.Cells[temp_i, temp_j] == 1)
                {
                    Lost();// you are lost. decrease a life.
                    return;
                }
            }

            if (dir == Direction.down)//tilt down
            {
                while (grid.Cells[temp_i, temp_j] != 1 && grid.Bottom[temp_i, temp_j] != 1 && temp_i < grid.M-1) //if it's not hole, keep going down
                {
                    temp_i++;
                }
                if (grid.Cells[temp_i, temp_j] == 1)
                {
                    Lost();// you are lost. decrease a life.
                    return;
                }
            }

            if(temp_i==grid.M-1 && temp_j==grid.N-1) //You won the game!
            {
                Console.WriteLine("Congratulations! You have won the game!");
                
            }
            cur_loc.I = temp_i;
            cur_loc.J = temp_j;
        }

        void Lost()
        {
            Lives--;
            if(Lives==0) //Game over!
            {
                Console.WriteLine("Game Over!");
            }
            else
            {
                Console.WriteLine("You stepped on a hole. Now you got " + Lives + " Lives and will start at location (0,0).");
                //start from positoin (0,0)
                cur_loc.I = 0;
                cur_loc.J = 0;
                
            }
        }
        
    }
}
