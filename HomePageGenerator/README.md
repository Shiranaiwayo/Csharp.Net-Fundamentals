# 🌐 C# Homepage Generator

A C# console-based homepage generator that creates HTML pages with a welcome message, announcements, and a list of courses. The project demonstrates object-oriented programming, encapsulation, validation, inheritance, and method overriding.

## 🚀 Key Logic & Features

- **HTML Generation:** Combines `HtmlTop()`, `HtmlBody()`, and `HtmlEnd()` through the public `GenerateHtml()` method.
- **Constructors:** Creates multiple website objects with different class names, courses, and optional messages.
- **Encapsulation:** Keeps fields and HTML helper methods private, exposing properties and methods where needed.
- **Validation:** Rejects empty class names, null arrays, and blank course names or messages.
- **String Formatting:** Trims course names and formats their capitalization.
- **Inheritance:** Extends `WebsiteGenerator` with `StyledWebsiteGenerator`.
- **Method Overriding:** Overrides the protected virtual `PrintHead()` method to add a `<head>` section with CSS.
- **Custom Styling:** Uses the `PrimaryColor` property to set the text color of paragraph elements.
- **Expression-Bodied Members:** Uses concise syntax for getters and methods that return a single expression.
- **Console Output:** Prints the generated HTML source to the console.

## 🛠️ Built With

- **Language:** C#
- **Framework:** .NET (Console Application)
- **IDE:** Visual Studio Community