using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2_opdracht
{
    class Program
    {
        

        static void Main(string[] args)
        {
            int numberOfIterations = 15;
            int faculteit = Faculteit(numberOfIterations);
            Console.WriteLine(faculteit);

            TowersOfHanoiIterative(5, "links", "rechts", "midden");

            NaturalnumberCalculator NaturalNumberCalc = new NaturalnumberCalculator(1, 2);
            NaturalNumberCalc.DevideAandB();

            Console.ReadKey();
        }

        static void TowersOfHanoiIterative(int number, string src, string dest, string alt)
        {
            var stack = new Stack<Move>();

            stack.Push(new Move(number, src, dest, alt));
            while (stack.Count != 0)
            {
                var move = stack.Pop();
                if (move.Number == 1)
                    Console.WriteLine("Move one disc from {0} to {1}", move.Src, move.Dest);
                else
                {
                    stack.Push(new Move(move.Number - 1, move.Alt, move.Dest, move.Src));
                    stack.Push(new Move(1, move.Src, move.Dest, move.Alt));
                    stack.Push(new Move(move.Number - 1, move.Src, move.Alt, move.Dest));
                }
            }
        }

        public static int Faculteit(int numberOfIterations)
        {
            int faculteit_answer = 1;
            for (int i = 1; i <= numberOfIterations; i++)
            {
                if (numberOfIterations == 1)
                {
                    faculteit_answer = 1;
                }
                else
                {
                    int faculteit_answer_control = faculteit_answer * i;
                    Console.WriteLine(faculteit_answer + " * " + i + " = " + faculteit_answer_control);
                    faculteit_answer = faculteit_answer * i;


                }
            }
            return faculteit_answer;

           
        }
    }

}
