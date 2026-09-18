namespace Menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Menu exercise Fund2 p.32 

            Console.WriteLine("Choose one of the following foods: \n1. Pizza \n2. Burger \n3. Salad");
            int choice = GetValidInput(1, 3);

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

            string[] foods = { "Pizza", "Burger", "Salad" };

            foreach (string food in foods)
            {
                if (choice == Array.IndexOf(foods, food) + 1)
                {
                    Console.WriteLine("Here is your " + food);
                }
            }

        }
        //Helper method for valiadating user input
        public static int GetValidInput(int min, int max)
        {
            int input;
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out input) && input >= min && input <= max)
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Invalid input. Try again.");
                }
            }
        }





    }
}
