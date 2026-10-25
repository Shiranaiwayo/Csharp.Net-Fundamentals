namespace HomePageGenerator;

public class StyledWebsiteGenerator : WebsiteGenerator
{
    public string PrimaryColor { get; }
    public StyledWebsiteGenerator(string className, string[] courses, string primaryColor, string[]? messages = null)
    : base(className, courses, messages)
    {
        PrimaryColor = primaryColor;
    }
    protected override string PrintHead()
    {
        return "<head>\n<style>\n" +
            $"p {{ color: {PrimaryColor}; }}\n" +
            "</style>\n</head>";
    }
}

