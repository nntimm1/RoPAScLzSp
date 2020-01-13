using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class GamePlay : Gesture
    {

        public void InstructionPrint()
        {


            Console.WriteLine("Here are the Instructions:");
            Console.WriteLine("\n *Rock crushes Scissors \n *Scissors cuts Paper \n *Paper covers Rock \n *Rock crushes Lizard \n *Lizard poisons Spock \n *Spock smashes Scissors \n *Scissors decapitates Lizard \n *Lizard eats Paper \n *Paper disproves Spock v\n *Spock vaporizes Rock");
            Console.WriteLine("Got it? Press \n 1 for Yes \n 2 for No");
            int GoodOnInstructions = int.Parse(Console.ReadLine());
            if (GoodOnInstructions == 2)
            {
                Console.WriteLine("You Can't Play!");
                
            }
            else
            {
                Console.WriteLine("Good Luck!");
            }

        }

    }
}
