using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Player : GamePlay
    {
        public string Hname1;
        public string Hname2;
        public string Cname;

     public Player()
        {

        }
        public void PlayerSelect()
        {
            Console.WriteLine("How Many Players Would You Like?");
            int NumberofPlayers = int.Parse(Console.ReadLine());
            if (NumberofPlayers == 1)
            {
                Console.WriteLine("Tell me your name?");
                string name = Console.ReadLine();
                this.Hname1 = name;
                Console.WriteLine("Welcome to the game!\n \n Would you like the instructions? \n Press \n 1 for Yes \n 2 for No");
                int needInstructions = int.Parse(Console.ReadLine());
                if (needInstructions == 1)
                {
                    InstructionPrint();
                }
                else
                {

                } 

            }
            else if (NumberofPlayers == 2)
            {
                Console.WriteLine("Tell me your name?");
                string name1 = Console.ReadLine();
                this.Hname1 = name1;
                Console.WriteLine("What is Player 2's name?");
                string name = Console.ReadLine();
                this.Hname2 = name;
                Console.WriteLine("Okay Humanoids, time to battle it out. \n \n Would you like the instructions? \n Press \n 1 for Yes \n 2 for No");
                string needInstructions = Console.ReadLine();

            }
            else if (NumberofPlayers >= 3)
            {
                Console.WriteLine("Thats too many players, try again.");
            }
            else
            {
                Console.WriteLine("Bot showdown it is!");
                this.Cname = "Ralph";
            }

            
        }
    }
}
