﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefence
{
    public class FastInvader : Invader
    {
        protected override int StepSize { get; } = 2;


        public FastInvader(Path path):base(path)
        {
                
        }
    }
}
