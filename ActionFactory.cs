using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCardGame
{
    public class ActionFactory
    {
        public IAction action;

        //This is a factory pattern method which will return the instance of the IAction type.
        public IAction GetUserAction(string actionType)
        {
            if (actionType.ToLower() == "play")
                action = new Play();
            else if (actionType.ToLower() == "shuffle")
                action = new Reshuffle();
            else
                action = new Restart();

            return action;
        }
    }
}
