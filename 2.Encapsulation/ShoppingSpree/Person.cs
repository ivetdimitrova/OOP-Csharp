using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSpree
{
    public class Person
    {
        public Person(string name, decimal money)
        {
            if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Name cannot be empty");
            if (money < 0) throw new ArgumentException("Money cannot be negative");

            this.Name = name;
            this.Money = money;
            bag = new List<Product>();
        }
        public string Name { get; }
        private List<Product> bag;
        public decimal Money { get; set; }

        public void Buy(Product product)
        {
            if(this.Money - product.Cost < 0)
                Console.WriteLine($"{this.Name} can't afford {product.Name}");
            else
            {
                this.Money -= product.Cost;
                bag.Add(product);

                Console.WriteLine($"{this.Name} bought {product.Name}");
            }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{this.Name} - ");
            if (this.bag.Count == 0)
                sb.Append("Nothing bought");
            else
            {
                for (int i = 0; i < bag.Count; i++)
                {

                    if (i == bag.Count - 1)
                    {
                        sb.Append($"{bag[i].Name}");
                        break;
                    }

                    sb.Append($"{bag[i].Name}, ");
                }
            }
            
            return sb.ToString();
        }
    }
}
