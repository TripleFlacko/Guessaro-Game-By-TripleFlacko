using System;

class GuessaroByTripleFlacko
{
    static void Main()
    {
        int triesCounter = 10;
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Guessaro is a Guess A Number Game created by TripleFlacko.\nYou'll have 10 tries to guess the number.");
        Console.WriteLine();
        bool loopBreak = false;

        while (true)
        {
            Random randomNumber = new Random();
            int computerNumber = randomNumber.Next(1, 101);

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Guess a number from 1 to 100: ");
                string playerInput = Console.ReadLine();
                bool isValid = int.TryParse(playerInput, out int playerNumber);

                if (isValid)
                {
                    if (playerNumber == computerNumber)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Congratulations! You guessed it!");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine();
                        Console.WriteLine(@"Type ""Y"" to play again or type ""N"" to quit the game:");
                        while (true)
                        {
                            string continueOrNot = Console.ReadLine().ToLower();
                            if (continueOrNot == "y" || continueOrNot == "yes")
                            {
                                triesCounter = 10;
                                loopBreak = true;
                                Console.Clear();
                                break;
                            }
                            else if (continueOrNot == "n" || continueOrNot == "no")
                            {
                                return;
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Invalid input. Please try again...");
                            }
                        }
                    }
                    else if (playerNumber < computerNumber)
                    {
                        triesCounter--;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Too Low\nYou have {triesCounter} tries left.");
                        Console.WriteLine();
                    }
                    else
                    {
                        triesCounter--;
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"Too High\nYou have {triesCounter} tries left.");
                        Console.WriteLine();
                    }
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Invalid input. Try again...");
                    Console.WriteLine();
                }
                if (loopBreak)
                {
                    loopBreak = false;
                    break;
                }
                if (triesCounter == 0)
                {
                    Console.WriteLine();
                    Console.WriteLine("Unfortunately, you lost. Do you want to try again?");
                    Console.WriteLine(@"Type ""Y"" to try again or type ""N"" to quit the game:");
                    while (true)
                    {
                        string continueOrNot = Console.ReadLine().ToLower();
                        if (continueOrNot == "y" || continueOrNot == "yes")
                        {
                            triesCounter = 10;
                            break;
                        }
                        else if (continueOrNot == "n" || continueOrNot == "no")
                        {
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input. Please try again...");
                        }
                    }
                }
            }
        }
    }
}