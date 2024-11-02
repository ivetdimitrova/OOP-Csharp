using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace PizzaCalories;

public class Topping
{
    private const int MinWeight = 1;
    private const int MaxWeight = 50;

    private Dictionary<string, double> _toppingsModifiers = new Dictionary<string, double>()
    {
        ["meat"] = 1.2,
        ["veggies"] = 0.8,
        ["cheese"] = 1.1,
        ["sauce"] = 0.9
    };

    public Topping(string toppingType, double weight)
    {
        if (!_toppingsModifiers.ContainsKey(toppingType.ToLower()))
            throw new ArgumentException($"Cannot place {toppingType} on top of your pizza.");

        if (weight < MinWeight || weight > MaxWeight)
            throw new ArgumentException($"{toppingType} weight should be in the range [1..50].");

        this.ToppingType = toppingType.ToLower();
        this.WeightInGrams = weight;
    }
    private string ToppingType { get; }
    private double WeightInGrams { get; }

    public double TotalCaloriesOfTopping => 2 * WeightInGrams * _toppingsModifiers[ToppingType];

}

