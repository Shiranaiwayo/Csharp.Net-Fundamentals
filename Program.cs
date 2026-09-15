namespace GuessingGame2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int randomNum = new Random().Next(1, 50);

            Console.Write("Hi! Let's play a game! Guess a number between 1 and 50: ");
            string input = Console.ReadLine();

            int guess;

            if (CheckIfInt(ref input)) ;
            {
                guess = (Convert.ToInt32(input));
            }


            if (guess < 1 || guess > 50 || !int.TryParse(input, out _))
            {
                Console.Write("Please enter a number greater than 0 and less than 51: ");
                guess = Convert.ToInt32(Console.ReadLine());
            }

            for (int guesses = 1; guesses < 10 && guess != randomNum; guesses++)
            {
                Console.Write("Wrong guess! " + (10 - guesses) + " tries left. Try again: ");
                guess = Convert.ToInt32(Console.ReadLine());
            }

            if (guess == randomNum)
            {
                Console.WriteLine("Congratulations! You guessed the number: " + randomNum);
            }
            else
            {
                Console.WriteLine("Sorry! You ran out of tries! The number was: " + randomNum);
            }
        }
        private static bool CheckIfInt(ref string input)
        {
            if (int.TryParse(input, out int _))
            {
                return true;
            }
            else
            {
                Console.Write("Please enter a valid number: ");
                input = (Console.ReadLine());
            }

            return true;
        }
    }
}
