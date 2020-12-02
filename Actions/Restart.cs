using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCardGame
{
    public class Restart : IAction
    {
        public void Action(List<Card> cards)
        {
            try
            {
                cards.Clear();
                for (int i = 1; i <= 4; i++)
                {
                    for (int j = 1; j <= 13; j++)
                    {
                        Card card = new Card((SuitType)i, (Number)j);
                        cards.Add(card);
                    }
                }

                Console.WriteLine("After restart the game, you have 52 new cards in hand in the sorted order");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Encounter an exception and the exception is " + ex.Message);
                throw ex;
            }
        }
    }
}
