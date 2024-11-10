using System;
using System.Runtime.InteropServices;
using System.Text;

namespace PlayCatch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int exceptionCount =0;
            while (exceptionCount < 3)
            {
                string[] command = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
                int index = 0;
                try
                {
                    switch (command[0])
                    {
                            
                        case "Replace":
                             index = IsValidIndex(command[1],numbers);
                            int element = IsValidElement(command[2]);

                            numbers[index] = element;

                            break;
                        case "Show": 
                            index = IsValidIndex(command[1], numbers);

                            Console.WriteLine(numbers[index]);
                            break;
                        case "Print":
                            index = IsValidIndex(command[1], numbers);
                            int endindex = IsValidIndex(command[2], numbers);

                            Print(numbers, index, endindex);
                            break;

                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                    exceptionCount++;
                }
                catch (FormatException ex)
                {

                    Console.WriteLine(ex.Message);
                    exceptionCount++;
                }
            }

            Console.WriteLine(string.Join(", ", numbers));
        }

        private static void Print(int[] numbers, int startIndex, int endIndex)
        {
            for (int i = startIndex; i <= endIndex; i++)
            {
                if (i == endIndex)
                {
                    Console.Write(numbers[i]);
                    break;
                }
                
                Console.Write(numbers[i] + ", ");
            }
            
            Console.WriteLine();
        }

        private static int IsValidElement(string e)
        {
            if (!int.TryParse(e, out int elment))
                throw new FormatException("The variable is not in the correct format!");

            return elment;
        }

        private static int IsValidIndex(string i, int[] numbers)
        {
            if (!int.TryParse(i, out int index))
                throw new FormatException("The variable is not in the correct format!");

            if (index < 0 || index >= numbers.Length)
                throw new ArgumentException("The index does not exist!");


            return index;
        }
    }
}
