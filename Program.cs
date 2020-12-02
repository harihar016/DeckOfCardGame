using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeckOfCardGame
{
    class Program
    {
        static void Main(string[] args)
        {
            DeckOfCards card = new DeckOfCards();
            Console.WriteLine("Welcome to the Deck of the Cards. Please enter your action");

            try
            {
                for (int i = 0; i < 52; i++)
                {
                    Console.WriteLine("Please choose any one action from the below option");
                    Console.WriteLine(
                        "Play\n" +
                        "Shuffle\n" +
                        "Restart\n");
                    var action = Console.ReadLine();

                    card.CallAction(action);

                    if (action == "restart")
                    {
                        Console.WriteLine("Restarted the application again.");
                        i = 0;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Encounter an exception and the exception is " + ex.Message);
                throw ex;
            }
        }
    }
}
