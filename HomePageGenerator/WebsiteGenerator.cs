namespace HomePageGenerator;

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

    public string GenerateHtml() => HtmlTop() + HtmlBody() + HtmlEnd();
    protected virtual string PrintHead() => "<head>\n</head>";
    private string HtmlTop()
    {
        var html = $"""
            <!DOCTYPE html>
            <html>
            {PrintHead()}
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
    private string HtmlEnd() => "</body>\n</html>\n";

}

