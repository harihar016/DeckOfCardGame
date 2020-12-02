using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCardGame
{
    public class Card
    {
        //Once you initiliased through constructor, then you cannot chnage the values of it.
        private readonly SuitType _suit;
        private readonly Number _number;

        public Card(SuitType suit, Number number)
        {
            _suit = suit;
            _number = number;
        }

        public string ShowCard()
        {
            return _suit.ToString() + "_" + _number.ToString();
        }
    }

    //Created the Enums for the SuitType to maintain the consistency in naming and values.
    public enum SuitType
    {
        Hearts = 1,
        Clubs = 2,
        Spades = 3,
        Diamonds = 4
    }

    //Created the Enums for the Number to maintain the consistency in naming and values.
    public enum Number
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13,
    }
}
