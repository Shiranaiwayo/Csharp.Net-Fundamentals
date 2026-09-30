namespace BasicSearchFunction;

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

        myDictionary.Add("Niklas", 31);

        Console.WriteLine($"Whose age do you want to inquire about? Choose from below: ");
        foreach (string name in myDictionary.Keys)
        {
            Console.WriteLine(name);
        }

        var shouldContinue = true;
        while (shouldContinue)
        {
            string input = Console.ReadLine()?.Trim() ?? "";

            if (!string.IsNullOrWhiteSpace(input))
            {
                string nameToSearch = FormatText(input);
                var person = SearchPerson(nameToSearch, myDictionary);
                Console.Write(person?.ToString() ?? "Invalid input, choose a name from the list: ");
                shouldContinue = person == null;
            }
            else
            {
                Console.Write("Invalid input, write a name from the list: ");
            }
        }
    }
    private static Person? SearchPerson(string nameToSearch, Dictionary<string, int> ages)
    {
        var isValid = ages.TryGetValue(nameToSearch, out int age);
        if (isValid)
        {
            return new Person(nameToSearch, age);
        }
        else
        {
            //or throw new KeyNotFoundException($"Person {nameToSearch} not found");
            return null;
        }
    }
    private static string FormatText(string input)
    {
        string formattedInput = char.ToUpper(input[0]) + input.Substring(1).ToLower();
        return formattedInput;
    }
}
public class Person
{
    public string Name { get; private set; }
    public int Age { get; private set; }
    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
    public override string ToString()
    {
        return $"{Name} is {Age} years old.\n";
    }
}