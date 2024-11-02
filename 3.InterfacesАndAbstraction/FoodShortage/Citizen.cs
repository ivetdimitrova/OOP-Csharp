using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodShortage
{
    public class Citizen : Person,IIdentifiable, IBirthable,IBuyer
    {
        public Citizen(string name,int age,string id,string birthdate) : base(name,age)
        {
            this.Id = id;
            this.Birthdate = birthdate;
        }

        public string Id { get; }
        public string Birthdate { get; }
        public int Food { get; private set; }
        public void BuyFood()
        {
            this.Food += 10;
        }
    }
}
