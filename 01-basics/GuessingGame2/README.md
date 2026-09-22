# 🎯 C# Console Guessing Game

An interactive and robust console-based guessing game built while learning C# and .NET. This project focuses on advanced error handling, logical loops, and dynamic user experiences.

## 🚀 What I Practiced
- **Do-While Loops:** Implemented a main application loop to make the game fully interactive, allowing the user to replay seamlessly without manually restarting the program.
- **Secure Data Validation:** Utilized `int.TryParse` to build a crash-proof input system that elegantly handles invalid inputs (like text or symbols) without crashing the application.
- **Random Number Generation:** Used the `Random` class to dynamically generate a secret target number within a specific range (1–50) for each unique round.
- **String Sanitization:** Employed `.Trim().ToUpper()` to clean and normalize user responses when confirming if they want to play again.

## 🛠️ Built With
- **Language:** C#
- **Framework:** .NET 8.0 / .NET 9.0 (Console Application)

## 📈 Future Goals
In the next phase, I hope to expand this project by adding difficulty levels (e.g., varying the number of allowed tries or changing the range of numbers) and introducing a local high-score system to track the fewest attempts taken to win.
