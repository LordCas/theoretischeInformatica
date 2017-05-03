using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_opdracht
{
    class NaturalnumberCalculator
    {
        public int NumberA { get; set; }
        public int NumberB { get; set; }

        public NaturalnumberCalculator(int numbera, int numberb)
        {
            this.NumberA = numbera;
            this.NumberB = numberb;
        }
        public int MultiplyAandB()
        {
            int Multiply = NumberA * NumberB;

            return Multiply;
        }

        public double DevideAandB()
        {
            double DevideAandB = NumberA / NumberB;

            return DevideAandB;
        }

        public int AbstractAfromB()
        {
            int AbstractAfromB = NumberA - NumberB;
            return AbstractAfromB;

        } 

        public void PowerAofB()
        {
            double PowerAofB = Math.Pow(NumberA, NumberB);
            if (PowerAofB > 0)
            {
                Console.WriteLine(PowerAofB);
            } 
            else
            {
                 Console.WriteLine("Not a natural number");
            }
        }
    }

    
}
