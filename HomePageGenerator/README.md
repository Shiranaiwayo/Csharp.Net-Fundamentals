# 🌐 C# Homepage Generator

A C# console application that generates HTML pages with a welcome message, announcements, and a list of courses, with optional CSS styling and browser preview. The project demonstrates object-oriented programming, encapsulation, validation, inheritance, abstract classes, and interfaces.

## 🚀 Key Logic & Features

- **HTML Generation:** Combines `HtmlTop()`, `HtmlBody()`, and `HtmlEnd()` through the public `GenerateHtml()` method.
- **Constructors:** Creates website objects with different class names, courses, and optional messages.
- **Encapsulation:** Keeps fields and internal helper methods private, exposing properties and methods where needed.
- **Validation:** Rejects empty class names, null arrays, and blank course names or messages.
- **String Formatting:** Trims course names and formats their capitalization.
- **Abstraction:** Uses `WebsiteGeneratorBase` as an abstract base class that requires a `GenerateHtml()` implementation.
- **Inheritance:** Extends `WebsiteGenerator` with `StyledWebsiteGenerator`.
- **Method Overriding:** Overrides the protected virtual `PrintHead()` method to add a `<head>` section with CSS.
- **Custom Styling:** Uses the `PrimaryColor` property to set the text color of paragraph elements.
- **Interfaces:** Defines the `IHtmlPage` contract with a `GetHtml()` method, implemented by `HtmlPage`.
- **Flexible Rendering:** Accepts an `IHtmlPage` in `RenderHtmlPage()`, allowing additional page implementations without changing the rendering method.
- **Browser Preview:** Uses the static `HtmlUtilities.DisplayHtmlInBrowser()` method to save HTML to a temporary file and open it in a browser.
- **Expression-Bodied Members:** Uses concise syntax for getters and methods that return a single expression.

## 🛠️ Built With

- **Language:** C#
- **Framework:** .NET (Console Application)
- **IDE:** Visual Studio Community