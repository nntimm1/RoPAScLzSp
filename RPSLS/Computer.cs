using System;
using System.Collections.Generic;
using System.Text;

namespace RPSLS
{
    public class Computer : Player
    {
        
        public Computer(string name1)
        {
            this.p2 = "";
            Random random = new Random();
        }
        public Computer()
        {
            
        }
    }
}
