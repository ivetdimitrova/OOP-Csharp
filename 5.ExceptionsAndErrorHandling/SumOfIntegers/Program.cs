using System.Data;

namespace SumOfIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split().ToArray();
            int integersSum = CalculateIntegersSum(input);
            Console.WriteLine($"The total sum of all integers is: {integersSum}");
        }

        private static int CalculateIntegersSum(string[] input)
        {
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                string element = input[i];

                try
                {
                    bool isInteger = long.TryParse(element, out long number);

                    if (number < int.MinValue || number > int.MaxValue)
                        throw new OverflowException($"The element '{element}' is out of range!");

                    if (!isInteger)
                        throw new FormatException($"The element '{element}' is in wrong format!");

                    sum += (int)number;
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message);

                }
                catch (OverflowException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine($"Element '{element}' processed - current sum: {sum}");
                }
            }

            return sum;
        }
    }
}
