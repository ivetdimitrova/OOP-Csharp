using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories;

public class Pizza
{
    private readonly List<Topping> _toppings;
    public Pizza(string name, Dough dough)
    {
        if (string.IsNullOrWhiteSpace(name) || name.Length > 15)
            throw new ArgumentException("Pizza name should be between 1 and 15 symbols.");


        this.Name = name;
        this.Dough = dough;
        _toppings = new List<Topping>();
    }

    public string Name { get; }
    public Dough Dough { get; }

    public IReadOnlyCollection<Topping> Toppings => _toppings.AsReadOnly();

    public void AddTopping(Topping topping)
    {
        if (_toppings.Count >= 10)
            throw new ArgumentException("Number of toppings should be in range [0..10].");

        _toppings.Add(topping);
    }

    public double CalculateTotalCalories => this.Dough.TotalCaloriesOfDough + _toppings.Sum(topping => topping.TotalCaloriesOfTopping);
    

    public override string ToString()
    {
        return $"{this.Name} - {this.CalculateTotalCalories:f2} Calories.";
    }
}





