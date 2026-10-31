using System.Diagnostics;

namespace HomePageGenerator;

public static class HtmlUtilities
{
    /// <summary>
    /// Save html content to a temporary file and open it in a browser
    /// </summary>
    /// <param name="pageTitle">Page-title is used as filename</param>
    /// <param name="htmlContent">Sets the html for the file that is to be display</param>
    /// <param name="openFile">Opens the file in browser. True is default</param>
    /// <param name="webbrowserName">Chrome is default but can be set to any webbrowser. Don't include .exe in the name<
    public static void DisplayHtmlInBrowser(string pageTitle, string htmlContent, bool openFile = true, string webbrowserName = "Brave")
    {
        pageTitle = pageTitle.Replace(" ", "_");
        var tempPath = System.IO.Path.GetTempPath();
        string htmlFile = Path.Combine(tempPath, $"{pageTitle}.html");
        File.WriteAllText(htmlFile, htmlContent);
        if (openFile)
        {
            Process process = new Process();
            process.StartInfo.UseShellExecute = true;
            process.StartInfo.FileName = webbrowserName;
            process.StartInfo.Arguments = @$"file:///{htmlFile}";
            process.Start();
        }
    }
}


