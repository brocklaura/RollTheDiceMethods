using System;

namespace RollTheDiceLab4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sides;
            string cont;
            int roll1;
            int roll2;


            Console.Write("Hello playa, please enter the number of sides each die should have: ");
            sides = int.Parse(Console.ReadLine());

            do
            {
                roll1 = RandomDiceRoll(sides);
                roll2 = RandomDiceRoll(sides);

                WinorLose(roll1, roll2, sides);

                Console.Write("Would you like to continue (y/n)?: ");
                cont = Console.ReadLine();
            } while (cont == "y" || cont == "Y");
        }

        static int RandomDiceRoll(int sides)
        {
            Random rnd = new Random();
            int diceRoll = rnd.Next(1, sides + 1);
            return diceRoll;
        }

        static void WinorLose(int die1, int die2, int sides)
        {
            int diceSum = die1 + die2;
            Console.WriteLine($"Die 1: {die1} \nDie 2: {die2} \nTotal: {diceSum}");

            if (sides == 6)
            {
                if (die1 == 1 && die2 == 1)
                {
                    Console.WriteLine("SNAKE EYES");
                }
                else if ((die1 == 1 && die2 == 2) || (die1 == 2 && die2 == 1))
                {
                    Console.WriteLine("ACE DEUCE");
                }
                else if ((die1 == 6) && (die2 == 6))
                {
                    Console.WriteLine("BOXCAR");
                }
                else if ((diceSum == 7) || (diceSum == 11))
                {
                    Console.WriteLine("WINNER WINNER CHICKEN DINNER");
                }
                else if ((diceSum == 2) || (diceSum == 3) || (diceSum == 12))
                {
                    Console.WriteLine("OH CRAP, CRAPS :(");
                }

            }
        }


    }
}
