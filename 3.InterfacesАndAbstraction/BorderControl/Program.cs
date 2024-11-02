namespace BorderControl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<IIdentifiable> entities = new List<IIdentifiable>();
            List<IBirthable> entities = new List<IBirthable>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] data = input.Split(' ', StringSplitOptions.RemoveEmptyEntries).ToArray();

                switch (data[0])
                {
                    case "Citizen":
                        Citizen citizen = new Citizen(data[1], int.Parse(data[2]), data[3], data[4]);
                        entities.Add(citizen);
                        break;
                    //case "Robot":
                    //    Robot robot = new Robot(data[1], data[2]);
                    //    entities.Add(robot);
                    //    break;
                    case "Pet":
                        Pet pet = new Pet(data[1], data[2]);
                        entities.Add(pet);
                        break;
                }
            }

           // string suffix = Console.ReadLine();

           // List<IIdentifiable> detained = entities.Where(e => e.Id.EndsWith(suffix)).ToList();
           // detained.ForEach(x => Console.WriteLine(x.Id));

            string specificYear = Console.ReadLine();
            var result = entities.Where(x => x.Birthdate.EndsWith(specificYear)).ToList();
            result.ForEach(x=> Console.WriteLine(x.Birthdate));




        }
    }
}
