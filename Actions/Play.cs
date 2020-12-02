using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCardGame
{
    public class Play : IAction
    {
        public void Action(List<Card> cards)
        {
            try
            {
                Card card = cards[cards.Count - 1];
                cards.Remove(card);
                Console.WriteLine("You have played the card " + card.ShowCard() + " and you have only " + cards.Count + " cards in hand");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Encounter an exception and the exception is " + ex.Message);
                throw ex;
            }
        }
    }
}
