using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class GamePlay
    {
        Player player = new Player();

        public void InstructionPrint()
        {

            Player player = new Player();
            Console.WriteLine("\n Here are the Instructions:");
            Console.WriteLine("\n *Rock crushes Scissors \n *Scissors cuts Paper \n *Paper covers Rock \n *Rock crushes Lizard \n *Lizard poisons Spock \n *Spock smashes Scissors \n *Scissors decapitates Lizard \n *Lizard eats Paper \n *Paper disproves Spock \n *Spock vaporizes Rock");
            Console.WriteLine("\n Ready to play? Press \n 1 for Yes \n 2 for No");
            int GoodOnInstructions = int.Parse(Console.ReadLine());
            if (GoodOnInstructions == 2)
            {
                Console.WriteLine("\nHow much longer do you want to wait? Back to the begining with you!\n\n");
                player.PlayerSelect();
                                
                
            }
            else
            {
                Console.WriteLine("\nGood Luck!\n");
                
            }


        }
        public void GameOn()
        {
            Player.PickAGesture1();
            Player.PickAGesture2();

        }
        

    }
}
