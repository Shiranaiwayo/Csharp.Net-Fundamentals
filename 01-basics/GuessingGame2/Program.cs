namespace GuessingGame2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool playAgain = true;

            do
            {
                Console.Clear(); //Clear the console for a fresh start
                int randomNum = new Random().Next(1, 51);

                Console.Write("Hi! Let's play a game! Guess a number between 1 and 50: ");
                int guess = GetValidGuess();

                int totalTries = 10;


                for (int guesses = 1; guesses < totalTries && guess != randomNum; guesses++)
                {
                    Console.Write($"Wrong guess! {totalTries - guesses} tries left. Try again: ");
                    guess = GetValidGuess();
                }

                if (guess == randomNum)
                {
                    Console.WriteLine($"Congratulations! You guessed the number: {randomNum}");
                }
                else
                {
                    Console.WriteLine($"Sorry! You ran out of tries! The number was: {randomNum}");
                }
                //Play again?
                Console.Write("Do you want to play again? (Y/N): ");
                string respone = Console.ReadLine().Trim().ToUpper();
                if (respone != "Y")
                {
                    playAgain = false;
                    Console.WriteLine("Thanks for playing! Goodbye!");
                }

            } while (playAgain);
        }
        //Helper method to get a valid guess from the user
        private static int GetValidGuess()
        {
            while (true)
            {
                string input = Console.ReadLine();
                //Check if it's a valid number
                if (!int.TryParse(input, out int parsedGuess))
                {
                    Console.Write("Please enter a valid number: ");
                    continue; //restarts the loop to ask again
                }
                //Check if it's within the right range
                if (parsedGuess < 1 || parsedGuess > 50)
                {
                    Console.Write("Please enter a number between 1 and 50: ");
                    continue; //restarts the loop to ask again
                }
                //If it passes both checks, return the valid guess
                return parsedGuess;
            }
        }
    }
}
