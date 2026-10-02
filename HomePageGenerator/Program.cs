namespace HomePageGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var html = "<!DOCTYPE html>\n" +
               "<html>\n" +
               "<body>\n";

            html += "<h1>Välkomna!</h1>\n";

            string[] courseList = {" C#", "daTAbaser", "csharp fORTsäTtning", "WebbuTVeCkling ", "clean Code  "};

            foreach (var course in courseList)
            {
                string formattedCourse = course.Trim().ToLower();
                formattedCourse = char.ToUpper(formattedCourse[0]) + formattedCourse.Substring(1); 
                html += $"<p>Kurs om {formattedCourse}</p>\n";
            }

            html += "</body>\n" +
                    "</html>\n";

            Console.WriteLine(html);
        }
    }
}
