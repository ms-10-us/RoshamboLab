﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoshamboLab
{
    internal class RockPlayer : Player
    {
        
        public override Roshambo GenerateRoshambo()
        {
            return Roshambo.Rock;
        }
    }
}
