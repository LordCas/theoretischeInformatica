using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_opdracht
{
    class Move
    {
        public int Number { get; private set; }

        public string Src { get; private set; }

        public string Dest { get; private set; }

        public string Alt { get; private set; }

        //constructor in het geval van andere 
        public Move(int number, string src, string dest, string alt)
        {
            this.Number = number;
            this.Src = src;
            this.Alt = alt;
            this.Dest = dest;
        }
    }
}
