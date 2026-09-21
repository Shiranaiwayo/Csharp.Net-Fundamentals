# 📋 C# Console Menu System

An interactive console-based navigation system built while mastering C# and .NET structure. This project focuses on building structured, scalable menus using loop-driven execution, dual-mode argument parsing, and recursive choice validation.

## 🔄 Project Evolution: How it Started vs. How it is Now

To see how much this project has improved, here is the journey of the codebase:

1. **The Beginning (Linear & Static):** 
   Originally, the program was purely linear. It displayed three food items, read a single input, matched it using a `foreach` loop with `Array.IndexOf`, and then instantly shut down. If the user wanted another dish, they had to manually restart the entire application.
2. **The Evolution (Persistent & Dynamic):** 
   - **Interactive Looping:** Introduced a continuous lifecycle loop controlled by an `isRunning` state, allowing users to order multiple times until choosing to exit (`y/n`).
   - **Command-Line Integration:** Upgraded the `Main(string[] args)` method to intercept startup arguments. Users can now bypass the interactive menu entirely by passing their choice directly when launching the application.
   - **Polymorphic Validation:** Refactored the `GetValidInput` helper method into a flexible tool. By utilizing a default/optional parameter (`string inputStr = null`), the same method now seamlessly processes both terminal text streams and command-line arguments, using recursion to fall back safely to user prompts if an invalid argument is supplied.

## 🚀 Key Practices & Features
- **Dual-Mode Input Processing:** Supports standard interactive runtime execution as well as instant startup execution via `args`.
- **Recursive Fail-Safe Validation:** Wrapped inputs in conditional checks that catch invalid numbers or boundary overflows without crashing.
- **Clean Architecture:** Removed all deprecated and commented-out code, relying entirely on Git version control history for tracking older iterations.

## 🛠️ Built With
- **Language:** C#
- **Framework:** .NET 8.0 / .NET 9.0 (Console Application)

## 📦 How to Run the Project Locally

Ensure you have the [.NET SDK](https://microsoft.com) installed before running.

1. **Clone this repository:**
   ```bash
   git clone https://github.com
   cd Menu
   ```

2. **Build the project:**
   ```bash
   dotnet build
   ```

3. **Standard Mode (Interactive Menu):**
   Runs the full loop and asks if you want to order another dish.
   ```bash
   dotnet run
   ```

4. **Argument Mode (Direct Command):**
   Skips the interactive menu and outputs the meal directly (e.g., Choice 1 = Pizza).
   ```bash
   dotnet run 1
   ```

## 📈 Future Goals
Moving forward, I intend to expand this script by transforming it into a master hub—a single navigation control panel that links and runs my other mini-projects (like a Calculator or a Guessing Game) directly from this single application menu.

