namespace HomePageGenerator;

internal class Program
{
    static void Main(string[] args)
    {
        string[] courses = { " C#", "daTAbaser", "c# fORTsäTtning", "WebbuTVeCkling ", "clean Code  " };

        string[] messages = 
        { 
            "Kom ihåg att läsa dagens material.",
            "Deadline för inlämning är 16/10!",
            "Lycka till med programmeringen!" 
        };

        var website1 = new WebsiteGenerator(".NET26S", courses, messages);

        var website2 = new WebsiteGenerator(
            ".NET27S", 
            new[] { "C#", "Databaser" },
            new[] { "Välkomna till den nya kursen!", "Vi ses på tisdag!" }
            );

        Console.WriteLine(website1.GenerateHtml());
        Console.WriteLine(website2.GenerateHtml());
    }

}

