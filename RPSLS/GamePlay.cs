using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class GamePlay
    {
        // Member variables
        Player player1;
        Player player2;

        public int choice1;

        public List<int> RockBeats = new List<int>() { 3, 4, };
        public List<int> PaperBeats = new List<int>() { 1, 5, };
        public List<int> ScissorsBeats = new List<int>() { 2, 4, };
        public List<int> LizardBeats = new List<int>() { 5, 2, };
        public List<int> SpockBeats = new List<int>() { 3, 1, };

        //Constructor
        
        public GamePlay()
        {
            
        }

        // member methods (CAN DO)

        public void RunGame() // master method
        {
            InstructionPrint();
            PlayerSelect();
            do
            {
                player1.PickGesture();
                player2.PickGesture();
                RoundResult();
                ScoreDisplay();
            }
            while ((player1.score <= 2 ) && (player2.score <= 2));
            AnnounceWinner();

        }

        public void InstructionPrint()
        {
            Console.WriteLine("          WELCOME TO ROCK, PAPER SCISSORS, LIZARD, SPOCK\n"); 
            Console.WriteLine("\n           Here are the Instructions:");
            Console.WriteLine("\n *Rock crushes Scissors \n *Scissors cuts Paper \n *Paper covers Rock \n *Rock crushes Lizard \n *Lizard poisons Spock \n *Spock smashes Scissors \n *Scissors decapitates Lizard \n *Lizard eats Paper \n *Paper disproves Spock \n *Spock vaporizes Rock");
            Console.WriteLine("\n Ready to play? Press \n 1 for Yes \n 2 for No");
            int GoodOnInstructions = int.Parse(Console.ReadLine());
            if (GoodOnInstructions == 2)
            {
                Console.WriteLine("\nHow much longer do you want to wait? " +
                    "Back to the begining with you!\n\n");
                RunGame();
            }
            else
            {
                Console.WriteLine("\nGood Luck!\n");
            }
        }

        public void PlayerSelect()
        {
            // somewhere in here
            // player2 should be instantiated as a human or comnputer

            player1 = new Human(" ");
            player2 = new Computer();

            Console.WriteLine("How many players are there? \n");
            int NumberofPlayers = int.Parse(Console.ReadLine());
            if (NumberofPlayers == 1) 
            {
                Console.WriteLine("          Tell me your name:");
                player1.name = Console.ReadLine();
                string player = player2.name;

                Console.WriteLine("\n Welcome to the game " + player1.name + "!\n My name is " + player2.name + " and I am going to take you down! \n");
                player2 = new Computer();
              
            }
            else if (NumberofPlayers == 2)
            {   player2 = new Human(" ");
                Console.WriteLine("Great! What is player 1's name?");
                player1.name = Console.ReadLine();
                
                Console.WriteLine("\n And what is Player 2's name?");
                player2.name = Console.ReadLine();
                
                Console.WriteLine("\n  Welcome to the game " + player1.name + " and " + player2.name + "!");
                
            }
            else if (NumberofPlayers >= 3)
            {
                Console.WriteLine("Thats too many players, try again.\n");
                PlayerSelect();
            }
            else
            {
                Console.WriteLine("We need 1 human to play silly! \n Try Again\n");
                PlayerSelect();
            }

        }

      

        public void RoundResult()
        {
            switch (player1.pickedGesture)
            {
                case 1:
                    if (player1.pickedGesture == 1 && RockBeats.Contains(player2.pickedGesture))
                    {
                        Console.WriteLine("\n" + player1.name + " Wins this round!");
                        player1.score++;
                    }
                    else if (player1.pickedGesture == 1 && player2.pickedGesture == 1)
                    {
                        Console.WriteLine("\n It's a tie, Try again");
                    }
                    else
                    {
                        Console.WriteLine("\n" + player2.name + " Wins this round!");
                        player2.score++;
                    }
                    break;
                case 2:
                    if (player1.pickedGesture == 2 && PaperBeats.Contains(player2.pickedGesture))
                    {
                        Console.WriteLine("\n" + player1.name + " Wins this round!");
                        player1.score++;
                    }
                    else if (player1.pickedGesture == player2.pickedGesture)
                    {
                        Console.WriteLine("\n It's a tie, Try again");
                    }
                    else
                    {
                        Console.WriteLine("\n" + player2.name + " Wins this round!");
                        player2.score++;
                    }
                    break;
                case 3:
                    if (player1.pickedGesture == 3 && ScissorsBeats.Contains(player2.pickedGesture))
                    {
                        Console.WriteLine("\n" + player1.name + " Wins this round!");
                        player1.score++;
                    }
                    else if (player1.pickedGesture == player2.pickedGesture)
                    {
                        Console.WriteLine("\n It's a tie, Try again");
                    }
                    else
                    {
                        Console.WriteLine("\n" + player2.name + " Wins this round!");
                        player2.score++;
                    }
                    break;
                case 4:
                    if (player1.pickedGesture == 4 && LizardBeats.Contains(player2.pickedGesture))
                    {
                        Console.WriteLine("\n" + player1.name + " Wins this round!");
                        player1.score++;
                    }
                    else if (player1.pickedGesture == player2.pickedGesture)
                    {
                        Console.WriteLine("\n It's a tie, Try again");
                    }
                    else
                    {
                        Console.WriteLine("\n" + player2.name + " Wins this round!");
                        player2.score++;
                    }
                    break;
                case 5:
                    if (player1.pickedGesture == 5 && SpockBeats.Contains(player2.pickedGesture))
                    {
                        Console.WriteLine("\n" + player1.name + " Wins this round!");
                        player1.score++;
                    }
                    else if (player1.pickedGesture == player2.pickedGesture)
                    {

                        Console.WriteLine("\n It's a tie, Try again");
                    }
                    else
                    {
                        Console.WriteLine("\n" + player2.name + " Wins this round!");
                        player2.score++;
                    }
                    break;

            }
        }

        public void AnnounceWinner()
        {
            if (player1.score == 3)
            {
                Console.WriteLine("\n" + player1.name + " WINS!");
            }
            else if (player2.score ==3)
            {
                Console.WriteLine("\n" +player2.name + " WINS!");
            }
        }

        public void ScoreDisplay()
        {
            Console.WriteLine("\n" + player1.name + " " + player1.score);
            Console.WriteLine(player2.name + " " + player2.score + "\n");
        }










        //public void PickGesture1()
        //{


        //    Console.WriteLine(player1.name + "it's your turn. Pick your move.");
        //    foreach (string gesture in player.Gestures)
        //    {
        //        Console.WriteLine(gesture);
        //    }
        //    int Choice1 = int.Parse(Console.ReadLine());
        //    int choice1 = Choice1;
        //    Console.WriteLine("\n" + player.player2 + "it's your turn. Pick your move.");
        //    foreach (string gesture in player.Gestures)
        //    {
        //        Console.WriteLine(gesture);
        //    }
        //    int Choice2 = int.Parse(Console.ReadLine());
        //    int choice2 = Choice2;


        //}
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
