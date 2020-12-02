using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCardGame
{
    public class Reshuffle : IAction
    {
        public void Action(List<Card> cards)
        {
            try
            {
                int n = cards.Count;
                while (n > 1)
                {
                    n--;
                    int k = new Random().Next(n + 1);
                    var value = cards[k];
                    cards[k] = cards[n];
                    cards[n] = value;
                }

                Console.WriteLine("Re-shuffled the cards successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Encounter an exception and the exception is " + ex.Message);
                throw ex;
            }
        }
    }
}
