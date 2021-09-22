using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Basic_Logic_and_OOP
{
    class Program
    {
       
             private static int curLeft;
        private static int curTop;
        private static bool[,] isUsedPixels;
        private static List<BaseShape> shapes;
        private static int shapesToPrint;
        static void Main(string[] args)
        {
            Point x = new Point(13,5);
            shapesToPrint = 3;
            Line l = new Line(x,'#');
            Triangle t = new Triangle(x,'^');
            SetConsole(80, 25);
            shapes = new List<BaseShape> { l, t };

            for (int i = 0; i < shapesToPrint; i++)
            {
                int pos = new Random().Next(shapes.Count);
                Point p = new Point(new Random().Next(80), new Random().Next(25));
                shapes[pos].PrintShape();
            }
            while (true)
            {
                GetNextStep();
                Thread.Sleep(50);
            }

        }

        static void SetConsole(int width, int height)
        {
            Console.CursorVisible = false;
            Console.SetWindowSize(width, height);
            curLeft = new Random().Next(width);
            curTop = new Random().Next(height);
            Console.SetCursorPosition(curLeft, curTop);
            isUsedPixels = new bool[width, height];
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write('*');
            isUsedPixels[width - 1, height - 1] = true;
        }

        static void GetNextStep()
        {
            ConsoleKeyInfo key = Console.ReadKey(true);
            switch (key.Key)
            {
                case ConsoleKey.UpArrow:
                    Move(curLeft, curTop - 1);
                    break;
                case ConsoleKey.DownArrow:
                    Move(curLeft, curTop + 1);
                    break;
                case ConsoleKey.RightArrow:
                    Move(curLeft + 1, curTop);
                    break;
                case ConsoleKey.LeftArrow:
                    Move(curLeft - 1, curTop);
                    break;
            }
        }

        static void Move(int newLeft, int newTop)
        {
            if (newLeft < Console.WindowWidth && newLeft > 0 && newTop < Console.WindowHeight && newTop > 0)
            {
                if (isUsedPixels[newLeft - 1, newTop - 1])
                {
                    //Console.WriteLine("Error");
                }
                else
                {
                    Console.SetCursorPosition(curLeft, curTop);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    //Console.Write(' ');
                    Console.Write('*');

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.SetCursorPosition(newLeft, newTop);
                    Console.Write('*');
                    isUsedPixels[newLeft - 1, newTop - 1] = true;
                    curLeft = newLeft;
                    curTop = newTop;
                }
            }
        }

    }
}
