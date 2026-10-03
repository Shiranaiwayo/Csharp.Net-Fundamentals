namespace HomePageGenerator;

internal class Program
{
    static void Main(string[] args)
    {
        string[] courses = { " C#", "daTAbaser", "c# fORTsäTtning", "WebbuTVeCkling ", "clean Code  " };

        string[] messages = { "Kom ihåg att läsa dagens material.",
            "Deadline för inlämning är 16/10!",
            "Lycka till med programmeringen!" };

        var html = HtmlTop(".NET26S", messages) + HtmlBody(courses) + HtmlEnd();

        Console.WriteLine(html);
    }
    static string HtmlTop(string who, string[] optionalMessages = null)
    {
        var html = "<!DOCTYPE html>\n" +
            "<html>\n" +
            "<body>\n" +
            $"<h1>Välkomna {who}!</h1>\n";
        if (optionalMessages != null)
        {
            var index = 1;
            foreach (var message in optionalMessages)
            {
                html += $"<p><b>Meddelande {index}:</b> {message}</p>\n";
                index++;
            }
        }
        return html;
    }

    static string HtmlBody(string[] courses)
    {
        var html = "<main>\n";
        foreach (var course in courses)
        {
            var formattedCourse = course.Trim().ToLower();
            formattedCourse = char.ToUpper(formattedCourse[0]) + formattedCourse.Substring(1);
            html += $"<p>Kurs om {formattedCourse}</p>\n";
        }
        html += "</main>\n";
        return html;
    }
    static string HtmlEnd()
    {
        var html = "</body>\n" +
                   "</html>\n";
        return html;
    }
}

