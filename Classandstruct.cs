using System;

namespace MODUL6._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Pen
    {
        public string color;
        public int cost;

        public Pen()
        {
            color = "Черный";
            cost = 100;

        }

        public Pen(string x, int y)
        {
            color = x;
            cost = y;
        }
    }

    class RectAngle
    {
        public int a;
        public int b;

        public int Square(int a, int b)
        {

            return a * b;

        }

        public RectAngle(int first, int second)
        {
            a = first;
            b = second;
        }

        public RectAngle(int side)
        {
            a = side;
            b = side;
        }

        public RectAngle()
        {
            a = 6;
            b = 4;
        }
    }
}
