namespace BasicSearchFunction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var myDictionary = new Dictionary<string, int>()
            {
                { "Samuel", 26},
                { "Erica", 34},
                { "Lena", 33},
                { "Bertil", 45}
            };

            Console.WriteLine($"Who's age do you want to inquire about? Choose from below: ");
            foreach (string name in myDictionary.Keys)
            {
                Console.WriteLine(name);
            }
            string? input = Console.ReadLine();
            PrintAge(myDictionary, input);

        }
        static void PrintAge(Dictionary<string, int> dic, string? name)
        {
            if (name != null)
            {
                Console.WriteLine($"{name} is {dic[name]} years old.");
            }
            else
            {
                Console.WriteLine("That is not a searchable name");
            }
        }
    }
}
