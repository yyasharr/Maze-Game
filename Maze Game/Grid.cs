using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    class Grid
    {
        int _m; //number of rows
        int _n; //number of columns
        int[,] _cells; //0 for normal, 1 for hole.
        int[,] _right;
        int[,] _left;
        int[,] _top;
        int[,] _bottom;

        public Grid (int Height , int Width, int[,] cells, int[,] right, int[,] left, int[,] top, int[,] bottom)
        {
            _m = Height;
            _n = Width;
            _cells = cells;
            _right = right;
            _left = left;
            _top = top;
            _bottom = bottom;
        }

        public int M { get { return _m; } }
        public int N { get { return _n; } }
        public int[,] Cells { get { return _cells; } }
        public int[,] Right { get { return _right; } }
        public int[,] Left { get { return _left; } }
        public int[,] Top { get { return _top; } }
        public int[,] Bottom { get { return _bottom; } }



    }
}
