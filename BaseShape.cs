using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basic_Logic_and_OOP
{
    abstract class BaseShape
    {
        public Point LeftTop { get; set; }
        public char TheChar { get; set; }

        public abstract void PrintShape();

        protected BaseShape(Point leftTop, char theChar)
        {
            LeftTop = leftTop;
            TheChar = theChar;
        }
    }
}
