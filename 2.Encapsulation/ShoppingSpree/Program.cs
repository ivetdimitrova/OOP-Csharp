namespace ShoppingSpree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] personAndMoney = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries).ToArray();
            string[] productAndCost = Console.ReadLine().Split(';',StringSplitOptions.RemoveEmptyEntries).ToArray();

            //List<Person> people = new List<Person>();
            //List< Product> products = new List< Product>();

            Dictionary<string, Person> people = new Dictionary<string, Person>();
            Dictionary<string, Product> products = new Dictionary<string, Product>();

            try
            {
                string[] data = null;
                for (int i = 0; i < personAndMoney.Length; i++)
                { 
                    data = personAndMoney[i].Split('=').ToArray();

                    Person person = new Person(data[0], decimal.Parse(data[1]));
                    people.Add(data[0] , person);
                }

                for (int i = 0; i < productAndCost.Length; i++)
                {
                    data = productAndCost[i].Split('=').ToArray();

                    Product product = new Product(data[0], decimal.Parse(data[1]));

                    products.Add(data[0],product);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return;
            }

            string command;
            while ((command = Console.ReadLine()) != "END")
            {
                string[] information = command.Split().ToArray();

                if (!people.ContainsKey(information[0]) || !products.ContainsKey(information[1]))
                    continue;

                people[information[0]].Buy(products[information[1]]);
            }

            foreach (var (name,person) in people)
            {
                Console.WriteLine(person.ToString());
            }
        }
    }
}
