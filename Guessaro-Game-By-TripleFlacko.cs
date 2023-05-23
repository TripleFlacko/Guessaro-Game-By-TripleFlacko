using System;

class GuessANumberByTripleFlacko
{
    static void Main()
    {
        Random randomNumber = new Random();
        int computerNumber = randomNumber.Next(1, 101);

        while (true)
        {
            Console.Write("Guess a number from 1 to 100: ");
            string playerInput = Console.ReadLine();
            bool isValid = int.TryParse(playerInput, out int playerNumber);

            if (isValid)
            {
                if (playerNumber == computerNumber)
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine();
                    break;
                }
                else if (playerNumber < computerNumber)
                {
                    Console.WriteLine("Too Low");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("Too High");
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Try again...");
                Console.WriteLine();
            }
        }
    }
}