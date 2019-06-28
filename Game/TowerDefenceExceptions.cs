using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefence
{
    class TowerDefenceExceptions : Exception
    {
        public TowerDefenceExceptions() { }
        public TowerDefenceExceptions(string message) : base(message) { }


    }

    class OutOfBoundsException : TowerDefenceExceptions
    {

        public OutOfBoundsException() : base() { }
        public OutOfBoundsException(string message) : base(message) { }
    }
}
