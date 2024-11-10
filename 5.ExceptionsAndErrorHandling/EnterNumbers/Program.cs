namespace EnterNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = ReadNumbers();
            Console.WriteLine(string.Join(", ", numbers));
        }

        private static int[] ReadNumbers()
        {
            int[] numbers = new int[10];
            int start = 1;
            const int end = 100;

            for (int i = 0; i < 10; i++)
            {
                while (true)
                {
                    try
                    {
                        string input = Console.ReadLine();

                        if (!int.TryParse(input, out int number))
                        {
                            throw new ArgumentException("Invalid Number!");
                        }

                        if (number <= start || number >= end)
                        {
                            throw new ArgumentException($"Your number is not in range {start} - {end}!");
                        }

                        
                        numbers[i] = number;
                        start = number; 
                        break; 
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
            }

            return numbers;
        }

    }
}
