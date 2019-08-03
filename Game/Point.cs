using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefence
{
    public class Point
    {
        public readonly int X;
        public readonly int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }

        public int DistanceToPoint(int x, int y)
        {   
            return (int)Math.Sqrt(Math.Pow(X - x,2) + Math.Pow(Y - y, 2));
        }

        public int DistanceToPoint(Point point)
        {
            return DistanceToPoint(point.X, point.Y);
        }


    }
}
