using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Logic_and_OOP
{
    struct Point
    {
        public int Left { get; set; }
        public int Top { get; set; }

        public Point(int left, int top)
        {
            Left = left;
            Top = top;
        }
    }
}
