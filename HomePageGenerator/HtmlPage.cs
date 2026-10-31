using System;
using System.Collections.Generic;
using System.Text;

namespace HomePageGenerator;

public class HtmlPage : IHtmlPage
{
    private readonly string _html;

    public HtmlPage(string html)
    {
        _html = html;
    }

    public string GetHtml() => _html;
    
}
