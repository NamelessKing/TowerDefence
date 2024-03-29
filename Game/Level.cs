﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TowerDefence
{
    class Level
    {
        private readonly Invader[] _invaders;

        public Tower[] Towers { get; set; }


        public Level(Invader[] invaders)
        {
            _invaders = invaders;
        }

        public bool Play()
        {
            int remainingInvaders = _invaders.Length;

            while (remainingInvaders > 0)
            {
                foreach (Tower tower in Towers)
                {
                    tower.FireOnInvders(_invaders);
                }


                remainingInvaders = 0;
                foreach (Invader invader in _invaders)
                {
                    if (invader.IsActive)
                    {
                        invader.Move();

                        if (invader.HasScored)
                        {
                            return false;
                        }

                        remainingInvaders++;
                    }    
                }
            }

            return true;
        }
    }
}
