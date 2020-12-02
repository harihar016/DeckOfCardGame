using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCardGame
{
    public interface IAction
    {
        void Action(List<Card> cards);
    }
}
