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

        public int DistanceToPoint(int x,int y)
        {
            int xDiff = X - x;
            int yDiff = Y - y;
            return (int)Math.Sqrt((xDiff*xDiff) + (yDiff * yDiff));
        }

        public int DistanceToPoint(Point point)
        {
            return DistanceToPoint(point.X,point.Y);
        }


    }
}
