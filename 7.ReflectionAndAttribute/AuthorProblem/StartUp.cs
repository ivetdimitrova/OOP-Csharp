using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthorProblem
{
    [Author("Victor")]
    public class StartUp
    {
        [Author("George")]
        static void Main(string[] args)
        {
            Tracker tracker = new Tracker();
            Console.WriteLine(string.Join(' ',GetNumbers(1 , 5)));
            tracker.PrintMethodsByAuthor();
        }

        [Author("Ivet")]
        public static List<int> GetNumbers(int start, int end)
        {
            List<int> numbers = new List<int>();
            for (int i = start; i <= end; i++)
            {
                numbers.Add(i);
            }

            return numbers;
        }
    }
}
