using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Player : GamePlay
    {
        public string p1;
        public string p2;
        

     public Player()
        {

        }
        public void PlayerSelect()
        {
            Console.WriteLine("How many players are there?");
            int NumberofPlayers = int.Parse(Console.ReadLine());
            if (NumberofPlayers == 1)
            {
                Console.WriteLine("Tell me your name:");
                string name = Console.ReadLine();
                this.p1 = name;
                Console.WriteLine("\n Welcome to the game " + p1 + "!\n \n Would you like the instructions? \n Press \n 1 for Yes \n 2 for No");
                int needInstructions = int.Parse(Console.ReadLine());
                if (needInstructions == 1)
                {
                    InstructionPrint();
                }
                else
                {
                    // PLACEHOLDER FOR GAME PLAY METHOD
                } 

            }
            else if (NumberofPlayers == 2)
            {
                Console.WriteLine("Tell me your name?");
                string name1 = Console.ReadLine();
                this.p1 = name1;
                Console.WriteLine("\n What is Player 2's name?");
                string name = Console.ReadLine();
                this.p2 = name;
                Console.WriteLine("\n  Welcome to the game " +p1+ " and " +p2 + "!\n \n Would you like the instructions? \n Press \n 1 for Yes \n 2 for No");
                int needInstructions = int.Parse(Console.ReadLine());
                if (needInstructions == 1)
                {
                    InstructionPrint();
                }
                else
                {
                    Console.WriteLine("Okay Humanoids, time to battle it out.");
                    // PLACEHOLDER FOR GAME PLAY METHOD
                }
                            }
            else if (NumberofPlayers >= 3)
            {
                Console.WriteLine("Thats too many players, try again.");
                PlayerSelect();
            }
            else
            {
                Console.WriteLine("We need 1 human to play silly! \n Try Again");
                PlayerSelect();
                
            }

            
        }
    }
}
