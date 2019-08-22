using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefence
{
    public class Tower
    {

        private const int _range = 1;
        private const int _power = 1;
        private const double _accuracy = .75;

        private static readonly Random _random = new Random();

        private MapLocation _location;


        public Tower(MapLocation location)
        {
            _location = location;
        }

        public bool IsSuccessfulShot()
        {
            return Tower._random.NextDouble() < _accuracy;
        }

        public void FireOnInvders(Invader[] invaders)
        {
            foreach (Invader invader in invaders)
            {
                if (invader.IsActive && _location.InRangeOf(invader.Location, _range))
                {
                    if (IsSuccessfulShot())
                    {
                        invader.DecreaseHealth(_power);

                        if (invader.IsNeutralized)
                        {
                            Console.WriteLine("\t-Neutralized an invader\n");
                        }
                    }
                    else
                    {
                        Console.WriteLine("\nShot at and miss an invader!\n");
                    }
                    break;
                }
            }
        }

    }
}
