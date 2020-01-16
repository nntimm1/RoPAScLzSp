using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Player
    {
        // Member variables

        public string name;
        public int score;
        public int pickedGesture;

        public List<string> Gestures = new List<string>() { " 1=Rock", " 2=Paper", " 3=Scissors", " 4=Lizard", " 5=Spock", };


        //Constructor

        public Player()
        {
            score = 0;

        }

        // member methods

        public virtual void PickGesture()
        {

            Console.WriteLine(this.name + " it's your turn. Pick your move.");
            foreach (string gesture in Gestures)
            {
                Console.WriteLine(gesture);
            }
        
        }
       
    }
}
