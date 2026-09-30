# 🔎 C# Console Basic Search Function

A simple console-based application built while learning dictionaries, methods, classes, properties, and input validation in C#. The application stores people's names and ages in a dictionary and allows the user to search for a person's age by entering their name.

## 🚀 Key Logic & Features

* **Dictionary:** Stores people's names and ages using a `Dictionary<string, int>`.
* **Person Class:** Uses a `Person` class with `Name` and `Age` properties to represent the search result.
* **Search Function:** Uses `TryGetValue()` to safely search the dictionary for a person's name.
* **Input Formatting:** Automatically formats the user's input so that names are handled consistently regardless of capitalization.
* **Input Validation:** Checks for empty or invalid input and asks the user to enter a valid name.
* **Looping:** Keeps the application running until a valid name is entered.

## 🛠️ Built With

* **Language:** C#
* **Framework:** .NET (Console Application)
* **IDE:** Visual Studio Community
