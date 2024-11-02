namespace PizzaCalories;

public class Program
{
    static void Main(string[] args)
    {
        string input;
        try
        {
            Pizza pizza = ReadPizza();
            Console.WriteLine(pizza);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);

        }
    }

    private static Pizza ReadPizza()
    {
        string[] pizzaData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
        string[] doughData = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

        Dough dough = new Dough(doughData[1], doughData[2], double.Parse(doughData[3]));

        Pizza pizza = new Pizza(pizzaData[1], dough);
        string input;
        while ((input = Console.ReadLine()) != "END")
        {
            string[] toppingData = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();
            Topping topping = new Topping(toppingData[1], double.Parse(toppingData[2]));

            pizza.AddTopping(topping);
        }

        return pizza;
    }
}

