namespace RomanNumeralConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number you want to convert to Roman Numerals: ");
            var input = Convert.ToInt32(Console.ReadLine());

            int[] values = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] romans = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            string romanNum = "";

            for (int i = 0; i < values.Length; i++)
            {
                while (input >= values[i])
                {
                    romanNum += romans[i];
                    input -= values[i];
                }
            }

            Console.WriteLine($"{input}: {romanNum}");
        }
    }
}
