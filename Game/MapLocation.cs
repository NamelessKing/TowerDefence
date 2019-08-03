using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefence
{
    public class MapLocation : Point
    {
        public MapLocation(int x,int y,Map map):base(x,y)
        {
            if (!map.IsPointOnMap(this))
            {
                throw new OutOfBoundsException($"x = {x},y = {y} " +
                    $"is outside the boundaries of this map");
            }
        }
    }
}
