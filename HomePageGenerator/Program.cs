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
public class WebsiteGenerator
{
    private string _className;
    private string[] _courses;
    private string[] _messages;

    public WebsiteGenerator(string className, string[] courses, string[]? messages = null)
    {
        _className = className;
        _courses = courses;
        _messages = messages ?? Array.Empty<string>();
    }
    

    public string GenerateHtml()
    {
        return HtmlTop() + HtmlBody() + HtmlEnd();
    }
    private string HtmlTop()
    {
        var html = $"""
            <!DOCTYPE html>
            <html>
            <body>
            <h1>Välkomna {_className}!</h1>\n
            """;

        var index = 1;
        foreach (var message in _messages)
        {
            html += $"<p><b>Meddelande {index}:</b> {message}</p>\n";
            index++;
        }
        return html;
    }

    private string HtmlBody()
    {
        var html = "<main>\n";
        foreach (var course in _courses)
        {
            var formattedCourse = course.Trim().ToLower();
            if (formattedCourse.Length == 0) 
                continue;
            formattedCourse = char.ToUpper(formattedCourse[0]) + formattedCourse.Substring(1);
            html += $"<p>Kurs om {formattedCourse}</p>\n";
        }
        return html + "</main>\n";
    }
    private string HtmlEnd()
    {
        return "</body>\n</html>\n";
    }
}

