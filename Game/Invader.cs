using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefence
{
    public class Invader
    {
        private readonly Path _path;
        private int _pathStep = 0;

        public static int InvadeNumber { get; } = 0;


        protected virtual int StepSize { get; } = 1;

        public MapLocation Location
        {
            get
            {
                return _path.GetMapLocationAt(_pathStep);
            }
        }

        public int Health { get; private set; } = 2;

        public bool HasScored
        {
            get
            {
                return _pathStep >= _path.Length;
            }
        }

        public bool IsNeutralized => Health <= 0;

        public bool IsActive => !(IsNeutralized || HasScored);




        public Invader(Path path)
        {
            _path = path;
            InvadeNumber++;
        }

        public void Move()
        {
            _pathStep += StepSize;
        }

        public virtual void DecreaseHealth(int factor)
        {
            Health -= factor;
            Console.WriteLine("Shot at and hit an indaver!");
        }

    }
}
