using System.Threading.Channels;
using Cards.Model;

namespace Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] cardsData = Console.ReadLine().Split(", ",StringSplitOptions.RemoveEmptyEntries).ToArray();

            List<Card> cards = new List<Card>();

            for (int i = 0; i < cardsData.Length; i++)
            {
                string[] cardData = cardsData[i].Split();

                string face = cardData[0];
                char suit = cardData[1][0];

                try
                {
                    Card card = new Card(face, suit);

                    cards.Add(card);
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine(ex.Message);
                   
                }
            }


           cards.ForEach(c => Console.Write(c.ToString() + ' '));



        }
    }
}
