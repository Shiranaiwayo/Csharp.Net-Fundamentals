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
    private string _className = "";
    private string[] _courses = Array.Empty<string>();
    private string[] _messages = Array.Empty<string>();

    public string ClassName
    { 
        get => _className; 
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("Klassnamnet får inte vara tomt.");
            }
            _className = value.Trim();
        }
    }
    public string[] Courses
    {
        get => _courses;
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(Courses));
            }

            if (value.Any(course => string.IsNullOrWhiteSpace(course)))
            {
                throw new ArgumentException("Kursnamn får inte vara tomma.");
            }
            _courses = value;
        }
    }
    public string[] Messages
    {
        get => _messages;
        set
        {
            if (value == null)
            {
                throw new ArgumentNullException(nameof(Messages));
            }
            if (value.Any(message => string.IsNullOrWhiteSpace(message)))
            {
                throw new ArgumentException("Meddelanden får inte vara tomma.");
            }
            _messages = value;
        }
    }

    public WebsiteGenerator(string className, string[] courses, string[]? messages = null)
    {
        ClassName = className;
        Courses = courses;
        Messages = messages ?? Array.Empty<string>();
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
            <h1>Välkomna {_className}!</h1>

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

