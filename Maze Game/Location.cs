using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maze_Game
{
    class Location
    {
        int _i;
        int _j;

        public Location()
        {
            _i = 0;
            _j = 0;
        }

        public int I
        {
            get { return _i; }
            set { _i = value; }
        }
        public int J
        {
            get { return _j; }
            set { _j = value; }
        }
    }
}
