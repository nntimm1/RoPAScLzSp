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

        public List<int> RockBeats = new List<int>() { 3, 4, };
        public List<int> PaperBeats = new List<int>() { 1, 5, };
        public List<int> ScissorsBeats = new List<int>() { 2, 4, };
        public List<int> LizardBeats = new List<int>() { 5, 2, };
        public List<int> SpockBeats = new List<int>() { 3, 1, };

        public int itsA_Tie;
        public int roundMax;

        //Constructor
        
        public GamePlay()
        {
            itsA_Tie = 0;
        }
       

        // member methods (CAN DO)

        public void RunGame() // master method
        {
            InstructionPrint();
            PlayerSelect();
            GameLength();
            do
            {
                player1.PickGesture();
                player2.PickGesture();
                RoundResult();
                ScoreDisplay();
            }
            while ((player1.score < roundMax) && (player2.score < roundMax));
            AnnounceWinner();

        }

        public void InstructionPrint()
        {
            Console.WriteLine("          WELCOME TO ROCK, PAPER SCISSORS, LIZARD, SPOCK\n"); 
            Console.WriteLine("\n           Here are the Instructions:");
            Console.WriteLine("\n *Rock crushes Scissors \n *Scissors cuts Paper \n *Paper covers Rock \n *Rock crushes Lizard \n *Lizard poisons Spock \n *Spock smashes Scissors \n *Scissors decapitates Lizard \n *Lizard eats Paper \n *Paper disproves Spock \n *Spock vaporizes Rock");
            Console.WriteLine("\n Ready to play? Press \n 1 for Yes \n 2 for No");
            int goodOnInstructions = 0;
            try
            {
                goodOnInstructions = int.Parse(Console.ReadLine());
                if (goodOnInstructions == 2)
                {
                    Console.WriteLine("\nHow much longer do you want to wait? " +
                                      "Back to the begining with you!\n\n");
                    RunGame();
                }
                else
                {
                    Console.WriteLine("\nGood Luck!\n");
                    Console.WriteLine("(Press ENTER to CONTINUE)");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("That is not a valid entry, try again");
                goodOnInstructions = int.Parse(Console.ReadLine()); 
            }                       
        }
        public void PlayerSelect()
        {
            player1 = new Human(" ");
            player2 = new Computer();

            Console.WriteLine("How many players are there? \n");
            int numberofPlayers = -1;
            try
            {
                numberofPlayers = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {

                Console.WriteLine("That is not a valid entry, try again");
                numberofPlayers = int.Parse(Console.ReadLine());
            }
            if (numberofPlayers == 1) 
            {
                Console.WriteLine("          Tell me your name:");
                player1.name = Console.ReadLine();
                


                Console.WriteLine("\n Welcome to the game " + player1.name + "!\n My name is " + player2.name + " and I am going to take you down! \n");
                player2 = new Computer();
                Console.WriteLine("(Press ENTER to CONTINUE)");
                Console.ReadLine();
                Console.Clear();

            }
            else if (numberofPlayers == 2)
            {   player2 = new Human(" ");
                Console.WriteLine("Great! What is player 1's name?");
                player1.name = Console.ReadLine();
                Console.Clear();

                Console.WriteLine("\n And what is Player 2's name?");
                player2.name = Console.ReadLine();

                
                Console.WriteLine("\n  Welcome to the game " + player1.name + " and " + player2.name + "!");
                Console.WriteLine("(Press ENTER to CONTINUE)");
                Console.ReadLine();
                Console.Clear();
            }
            else if (numberofPlayers >= 3)
            {
                Console.WriteLine("Thats too many players, try again.\n");
                PlayerSelect();
            }
            else
            {
                player1 = new Computer();
                player2 = new Computer();
                Console.WriteLine("\n A Robot Battle it is! \n\n What do you want to name player 1?");
                player1.name = Console.ReadLine();

                Console.WriteLine("\n And what Should we name Player 2?");
                player2.name = Console.ReadLine();
            }

        }
        public void GameLength()
        {
            roundMax = 0;
            try
            {
                while (roundMax < 3)
                {
                    Console.WriteLine("How many rounds would you like to play today?");
                    roundMax = int.Parse(Console.ReadLine());
                }
            }
            catch (Exception)
            {
                    Console.WriteLine("That is not a valid entry, try again");
                    roundMax = int.Parse(Console.ReadLine());
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
                        itsA_Tie++;
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
                        itsA_Tie++;
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
                        itsA_Tie++;
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
                        itsA_Tie++;
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
                        itsA_Tie++;
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
            int playAgain = 0;
            if (player1.score == roundMax)
            {
                Console.WriteLine("\n" + player1.name + " WINS!");
                Console.WriteLine("          Total Ties This Game " + itsA_Tie);
                Console.WriteLine("\n          Total Rounds Played This Game " + (player1.score+player2.score+itsA_Tie));
                Console.WriteLine("\n Want to play again? \n 1 Yes \n 2 No");
                try
                {
                    playAgain = int.Parse(Console.ReadLine());
                    if (playAgain == 1)
                    {
                        RunGame();
                    }
                    else
                    {
                        Console.WriteLine("\n Thanks for playing, have a good day! \n ");
                        Console.WriteLine("(Press ENTER to CONTINUE)");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("That is not a valid entry, try again");
                    playAgain = int.Parse(Console.ReadLine());
                }
            }
            else if (player2.score == roundMax)
            {
                Console.WriteLine("\n" +player2.name + " WINS! \n ");
                Console.WriteLine("          Total Ties This Game " + itsA_Tie);
                Console.WriteLine("\n          Total Rounds Played This Game " + (player1.score + player2.score + itsA_Tie));
                Console.WriteLine("\nWant to play again? \n 1 Yes \n 2 No");
                try
                {
                    playAgain = int.Parse(Console.ReadLine());
                    if (playAgain == 2)
                    {
                        Console.WriteLine("\n Thanks for playing, have a good day! \n ");
                        Console.WriteLine("(Press ENTER to CONTINUE)");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("\n Thanks for playing, have a good day! \n ");
                        Console.WriteLine("(Press ENTER to CONTINUE)");
                        Console.ReadLine();
                        Console.Clear();
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("That is not a valid entry, try again");
                    playAgain = int.Parse(Console.ReadLine());
                }
            }
        }
        public void ScoreDisplay()
        {
            Console.WriteLine("\n" + player1.name + " " + player1.score);
            Console.WriteLine(player2.name + " " + player2.score + "\n");


        }

    }
}
