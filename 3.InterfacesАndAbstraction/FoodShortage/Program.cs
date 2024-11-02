namespace FoodShortage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int peopleCount = int.Parse(Console.ReadLine());
          //  List<IBuyer> buyers = new List<IBuyer>();
           Dictionary<string,IBuyer> buyers = new Dictionary<string,IBuyer>();
            for (int i = 0; i < peopleCount; i++)
            {
                string[] data = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (data.Length == 4)
                {
                    Citizen citizen = new Citizen(data[0], int.Parse(data[1]), data[2], data[3]);
                    buyers.Add(data[0],citizen);
                }
                else
                {
                    Rebel rebel = new Rebel(data[0], int.Parse(data[1]), data[2]);
                    buyers.Add(data[0],rebel);
                }
            }

            string inputName;
            while ((inputName = Console.ReadLine()) != "End")
            {
                if(!buyers.ContainsKey(inputName))
                    continue;

                buyers[inputName].BuyFood();
            }

            int totalFood = 0;

            foreach (var (name,person) in buyers)
            {
                totalFood += person.Food;
            }

            Console.WriteLine(totalFood);
        }
    }
}
