using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    public abstract class BaseHero
    {
        public BaseHero(string name)
        {
            Name = name;
        }

        public string Name { get; }
        public virtual int Power { get; }

        public virtual string CastAbility()
        {
            return $"{this.GetType().Name} - {Name}";
        }
    }
}
