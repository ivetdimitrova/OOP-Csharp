using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    public class Warrior : BaseHero
    {
        public Warrior(string name) : base(name)
        {
        }

        public override int Power => 100;

        public override string CastAbility()
        {
            return base.CastAbility() + $" hit for {Power} damage";
        }
    }
}
