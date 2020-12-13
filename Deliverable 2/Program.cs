using System;

namespace Deliverable_2
{
    class Program
    {
        static void Main(string[] args)
        {   //Declaring variables and setting counters to 0
            string headsOrTailsGuess;
            double numberOfFlips;
            double correctCount = 0;
            //Asking user to input guess and number of iterations
            Console.WriteLine("Guess which will have more: heads or tails?");
            headsOrTailsGuess = Console.ReadLine();
            Console.WriteLine("How many times shall we flip a coin?");
            // Turning string var into integer to use as the iterations for the loop
            numberOfFlips = int.Parse(Console.ReadLine());
            //Begining of the Loop for total flips
            for (int ctr = 0; ctr <= numberOfFlips; ctr++) {
                Random rng = new Random(); // Setting up the random number generation
                int result = rng.Next(0, 2); // result will allow for conditionals to switch between Heads or Tails
                if (result == 1)
                {
                  Console.WriteLine("Tails!"); //Output for Tails when 1 is generated
                    
                    if (headsOrTailsGuess == "tails") //conditional of whether they guessed right or not
                    {
                        correctCount++;
                    }
                }
                else if (result == 0)
                {
                  Console.WriteLine("Heads!"); //Output for Heads when 0 is generated

                    if (headsOrTailsGuess == "heads") //conditional of whether they guessed right or not
                    {
                        correctCount++;
                    }
                }
            }
            double percent = correctCount / numberOfFlips; //calculates the integer for how accurate their guess was
            percent = percent * 100; //converting to percentage
            Console.WriteLine("Your guess, {0}, came up {1} time(s).", headsOrTailsGuess, correctCount); //Final output tell them how many they got right
            Console.WriteLine("That's {0}%.", percent); // Outputs how accurate they were with their guess

        }
    }
}
