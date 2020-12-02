using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCardGame
{
    public class DeckOfCards
    {
        List<Card> cards = new List<Card>();
        public DeckOfCards()
        {
            Initialise();
        }

        //Initialised the cards for the first time
        public void Initialise()
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    Card card = new Card((SuitType)i, (Number)j);
                    cards.Add(card);
                }
            }
        }

        //Here we call the factory method to get the instance of a particular class of Action type. 
        //In case, if we need to provide one more action to the user in future, simply extend the IAction interface by implementing a new class and pass that type to this method dynamically.
        //and we dont need to make any changes to the exusting code.
        public void CallAction(string actionType)
        {
            IAction action = new ActionFactory().GetUserAction(actionType);
            action.Action(cards);
        }
    }
}
