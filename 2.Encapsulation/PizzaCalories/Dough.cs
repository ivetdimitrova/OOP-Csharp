using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaCalories;

public class Dough
{
    private const int MinWeight = 1;
    private const int MaxWeight = 200;

    private readonly Dictionary<string, double> _flourTypeModifiers = new Dictionary<string, double>()
    {
        ["white" ] = 1.5,
        ["wholegrain"] = 1.0
    };

    private readonly Dictionary<string, double> _bakingTechniqueModifiers = new Dictionary<string, double>()
    {
        ["crispy"] = 0.9,
        ["chewy"] = 1.1,
        ["homemade"] = 1.0
    };


    public Dough(string flourType, string bakingTechnique,double weight)
    {

        var lowerFlourType = flourType.ToLower();
        var lowerBakingTechnique = bakingTechnique.ToLower();

        if (!_flourTypeModifiers.ContainsKey(lowerFlourType) || !_bakingTechniqueModifiers.ContainsKey(lowerBakingTechnique))
            throw new ArgumentException("Invalid type of dough.");

        if (weight < MinWeight || weight > MaxWeight)
            throw new ArgumentException("Dough weight should be in the range [1..200].");

        this.FlourType = lowerFlourType;
        this.BakingTechnique = lowerBakingTechnique;
        this.WeightInGrams = weight;
        

    }

    private string FlourType { get; }
    private string BakingTechnique { get; }

    private double WeightInGrams { get; }

    public double TotalCaloriesOfDough => 2 * WeightInGrams * _flourTypeModifiers[FlourType] * _bakingTechniqueModifiers[BakingTechnique];

}

