using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WildFarm.DerivedClasses_Animal;
using WildFarm.Models;

namespace WildFarm.DerivedClasses_Bird
{
    public class Hen :Bird
    {
        public override string Sound => "Cluck";
        public Hen(string name, double weight, double wingSize) : base(name, weight, wingSize)
        {
        }

        public override double IncreasedWeight => 0.35;

    }
}
