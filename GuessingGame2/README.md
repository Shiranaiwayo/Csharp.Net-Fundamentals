# 🎯 C# Console Guessing Game

An interactive console-based guessing game built while learning C# and .NET. This project focuses on loops, methods, input validation, random number generation, and basic program flow.

## 🚀 What I Practiced
* **Do-While Loops:** Used a `do-while` loop to allow the player to start a new round after completing a game.
* **Input Validation:** Used `int.TryParse` to handle non-numeric input without crashing the application and added range validation to ensure guesses are between 1 and 50.
* **Random Number Generation:** Used the `Random` class to generate a secret number between 1 and 50 for each round.
* **Methods:** Separated the guess validation and input handling into a reusable `GetValidGuess()` method.
* **String Handling:** Used `.Trim().ToUpper()` when processing the player's response to the replay prompt.

## 🛠️ Built With
- **Language:** C#
- **Framework:** .NET 8.0 / .NET 9.0 (Console Application)
- **IDE:** Visual Studio Community

## 📈 Future Goals
* Add different difficulty levels with varying numbers of attempts.
* Allow the player to choose the number range.
* Track the number of attempts used in each round.
* Add a high-score system based on the fewest attempts.



