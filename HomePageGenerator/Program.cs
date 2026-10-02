namespace HomePageGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var top = "<!DOCTYPE html>" +
               "<html>" +
               "<body>";

            var headline = "<h1>Välkomna!</h1>";

            var courses = "<p>Kurs om C#</p>" +
                            "<p>Kurs om Databaser</p>" +
                            "<p>Kurs om Webbutveckling</p>" +
                            "<p>Kurs om Clean code</p>";

            var end = "</body>" +
                          "</html>";

            var html = top + headline + courses + end;

            Console.WriteLine(html);
        }
    }
}
