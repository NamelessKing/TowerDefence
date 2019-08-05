using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefence
{
    public class Path
    {
        private readonly MapLocation[] _path;
        public int Length => _path.Length;

        public Path(MapLocation[] path)
        {
            _path = path;
        }

        public MapLocation GetMapLocationAt(int pathStepIndex)
        {
            return (pathStepIndex < _path.Length) ? _path[pathStepIndex] : null;
        }

    }
}
