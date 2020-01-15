using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Computer : Player
    {
        // Member variables

        Random random = new Random();


        //Constructor

        public Computer()
        {
            this.name = "Merlin";
        }


        // member methods
        public override void PickGesture()
        {
            base.PickGesture();
            pickedGesture = random.Next(1, 6);
            Console.WriteLine(pickedGesture);
        }

    }
}
