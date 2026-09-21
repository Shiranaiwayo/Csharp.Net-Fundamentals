using System.Runtime.InteropServices;

namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Menu exercise with switch

            //Console.WriteLine("Choose one of the following foods: \n1. Pizza \n2. Burger \n3. Salad");
            //int choice = GetValidInput(1, 3);

            //switch (choice)
            //{
            //    case 1:
            //        Console.WriteLine("Here is your Pizza!");
            //        break;
            //    case 2:
            //        Console.WriteLine("Here is your Burger!");
            //        break;
            //    case 3:
            //        Console.WriteLine("Here is your Salad!");
            //        break;
            //    default:
            //        Console.WriteLine("That input is not valid. Please choose a number between 1 and 3.");
            //        break;
            //}

            //Improvement with array, foreach, input validation, as well as rerun ability

            string[] foods = { "Pizza", "Burger", "Salad" };
            //for input through Command Prompt
            if(args.Length > 0 )
            {
                int choice = GetValidInput(1, 3, args[0]);
                Console.WriteLine("Here is your " + foods[choice-1]);
                Console.WriteLine("Thank you for dining with us today!");
            }

            bool isRunning = true;
            while (isRunning)
            {
                Console.WriteLine("Choose one of the following foods: \n1. Pizza \n2. Burger \n3. Salad");
                int choice = GetValidInput(1, 3);

                foreach (string food in foods)
                {
                    if (choice == Array.IndexOf(foods, food) + 1)
                    {
                        Console.WriteLine("Here is your " + food);
                    }
                }
                Console.Write("Do you want to choose another dish y/n?: ");
                string answer = Console.ReadLine().Trim().ToLower();
                if (answer == "n")
                {
                    Console.WriteLine("Thank you for dining with us today!");
                    isRunning = false;
                }
            }

        }
        //Helper method for valiadating user input, also through command
        public static int GetValidInput(int min, int max, string inputStr = null)
        {
            int input;
            string textToParse = inputStr ?? Console.ReadLine();

            if (int.TryParse(textToParse, out input) && input >= min && input <= max)
            {
                return input;
            }
            Console.WriteLine("Invalid input. Try again.");
            return GetValidInput(min, max);
        }





    }
}
