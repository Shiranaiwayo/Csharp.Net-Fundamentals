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

            Console.WriteLine(myDictionary["Samuel"]);

        }
    }
}
