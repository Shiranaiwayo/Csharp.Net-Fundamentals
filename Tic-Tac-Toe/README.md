# 🎮 C# Tic-Tac-Toe

A two-player console-based Tic-Tac-Toe game built with C# and OOP. Players can choose to compete against another player or a computer opponent that makes randomized moves.

The project demonstrates encapsulation, interfaces, dependency injection, input validation, game logic, and automated gameplay testing.

## 🚀 Key Logic & Features

- **Object-Oriented Design:** Separates responsibilities into dedicated classes for game logic, board management, player information, and user interaction.
- **Game Modes:** Supports two human players or a single player against the computer.
- **Player Registration:** Allows players to register their names and assigns `X` and `O` symbols.
- **Game Board:** Uses a private `string[]` to store the 9 board positions and `StringBuilder` to generate the board display.
- **Encapsulation:** Protects internal game data using private fields, read-only properties, and controlled access through methods.
- **Interfaces:** Uses `IUI` to define a common interface for user interaction, allowing different UI implementations.
- **Dependency Injection:** Passes an `IUI` implementation into the `Game` constructor, keeping game logic independent of the console.
- **Input Validation:** Validates player names and ensures moves are numbers between 1 and 9.
- **Move Validation:** Prevents moves on occupied squares and rejects invalid symbol placement.
- **Computer Opponent:** Uses `Random.Next()` to select available squares for the computer's moves.
- **Win & Draw Detection:** Checks all eight winning combinations and detects when the board is full.
- **Player Switching:** Alternates between players after each valid move.
- **Console Display:** Dynamically displays available squares, player symbols, and game results.
- **Automated Gameplay Testing:** Uses `TestUI` with predefined inputs to simulate complete games without manual console interaction.

## 🏗️ Project Structure

- **`Program.cs`:** Entry point that initializes the UI and starts the game.
- **`Game.cs`:** Manages game modes, player registration, turn switching, input validation, and computer moves.
- **`Board.cs`:** Manages the board, symbol placement, display generation, and win/draw detection.
- **`Player.cs`:** Stores player names and symbols using properties and a constructor.
- **`IUI.cs`:** Defines the interface for user input and output.
- **`ConsoleUI.cs`:** Handles console input, output, and screen clearing.
- **`TestUI.cs`:** Simulates user input and records output for automated gameplay testing.

## 🛠️ Built With

- **Language:** C#
- **Framework:** .NET 10 (Console Application)
- **IDE:** Visual Studio Community
