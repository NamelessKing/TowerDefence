﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefence
{
    public class Map
    {
        public readonly int Width;
        public readonly int Height;

        public Map()
        {
        }

        public Map(int width, int height)
        {
            Width = width;
            Height = height;
        }


        public bool IsPointOnMap(Point point) {
           
            bool inBounds = point.Y >= 0 && point.Y < this.Height && 
                            point.X >= 0 && point.Y < this.Width;
            return inBounds;
        }

    }
}
