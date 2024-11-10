namespace SquareRoot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = int.Parse(Console.ReadLine());

            try
            {
                double squareRoot = CalculateSquareRoot(number);

                Console.WriteLine(squareRoot);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Goodbye.");
            }
            
        }

        private static double CalculateSquareRoot(double number)
        {
            if (number < 0)
                throw new ArgumentException("Invalid number.");


            return Math.Sqrt(number);
        }
    }
}
