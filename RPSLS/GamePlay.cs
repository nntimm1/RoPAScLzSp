using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class GamePlay
    {
        // Member variables

        //Player player = new Player();
        public int choice1;
        public int choice2;

      //Constructor

        public GamePlay()
        {
            
        }

        // member methods

        public void InstructionPrint()
        {

            Player player = new Player();
            Console.WriteLine("\n Here are the Instructions:");
            Console.WriteLine("\n *Rock crushes Scissors \n *Scissors cuts Paper \n *Paper covers Rock \n *Rock crushes Lizard \n *Lizard poisons Spock \n *Spock smashes Scissors \n *Scissors decapitates Lizard \n *Lizard eats Paper \n *Paper disproves Spock \n *Spock vaporizes Rock");
            Console.WriteLine("\n Ready to play? Press \n 1 for Yes \n 2 for No");
            int GoodOnInstructions = int.Parse(Console.ReadLine());
            if (GoodOnInstructions == 2)
            {
                Console.WriteLine("\nHow much longer do you want to wait? " +
                    "Back to the begining with you!\n\n");
                player.PlayerSelect();
                                
                
            }
            else
            {
                Console.WriteLine("\nGood Luck!\n");
                PickGesture1();


            }


        }
        public void PickGesture1()
        {

            Player player = new Player();
            Console.WriteLine(player.p1 + "it's your turn. Make your move.");
            foreach (string gesture in player.Gestures)
            {
                Console.WriteLine(gesture);
            }
            int Choice1 = int.Parse(Console.ReadLine());
            int choice1 = Choice1;
            Console.WriteLine("\n" + player.p2 + "it's your turn. Make your move.");
            foreach (string gesture in player.Gestures)
            {
                Console.WriteLine(gesture);
            }
            int Choice2 = int.Parse(Console.ReadLine());
            int choice2 = Choice2;


        }
        //public void PickGesture2()
        //{

        //    Player player = new Player();
        //    Console.WriteLine(player.p2 + "it's your turn. Make your move.");
        //    foreach (string gesture in player.Gestures)
        //    {
        //        Console.WriteLine(gesture);
        //    }
        //    int Choice2 = int.Parse(Console.ReadLine());
        //    int choice2 = Choice2;

        //}



    }
}
