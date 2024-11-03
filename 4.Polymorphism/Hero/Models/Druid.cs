﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    public class Druid : BaseHero
    {
        public Druid(string name) : base(name)
        {
        }

        public override int Power => 80;

        public override string CastAbility()
        {
            return base.CastAbility()+   $" healed for {Power}";
        }
    }
}
