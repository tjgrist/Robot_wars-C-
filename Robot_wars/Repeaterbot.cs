﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robot_wars
{
    class Repeaterbot : Robot
    {
        public Repeaterbot()
        {
            name = "MACHINAroboMACHINArobo";
        }
    }
    public void subtract_hitpoints()
    {
        hit_points -= 10;
    }
}
