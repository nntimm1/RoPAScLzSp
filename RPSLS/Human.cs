using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Human : Player // inheritance (IS A TYPE OF)
    {
        // Member variables (HAS A)

                 
       //Constructor

        public Human(string name)
        {
            this.name = name;           
        }


        // member methods
        public override void PickGesture()
        {
            base.PickGesture();
            pickedGesture = int.Parse(Console.ReadLine());
        }

    }
}
