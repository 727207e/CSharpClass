﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleGame
{
    class Zombie : Monster
    {
        public override void Init()
        {
            base.Init();
            name = "Zombie";
        }
    }
}
