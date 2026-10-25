# 🎮 C# Tic-Tac-Toe

A two-player console-based Tic-Tac-Toe game built with C# and Object-Oriented Programming (OOP). Players register their names and take turns choosing squares from 1–9. The project focuses on classes, objects, encapsulation, properties, constructors, input validation, and game logic.

## 🚀 Key Logic & Features

- **Object-Oriented Design:** Separates responsibilities into `Game`, `Board`, and `Player` classes for better readability and maintainability.
- **Player Registration:** Allows two players to register their names and assigns them `X` and `O` symbols.
- **Game Board:** Uses a private `string[]` to store the 9 board positions.
- **Encapsulation:** Protects internal game data using private fields and controlled access through methods and properties.
- **Constructors & Properties:** Uses a `Player` constructor and read-only properties to initialize and store player information.
- **Input Validation:** Ensures players enter valid numbers between 1 and 9 and prevents empty player names.
- **Move Validation:** Prevents players from choosing occupied squares and validates symbol placement.
- **Win & Draw Detection:** Checks all eight winning combinations and detects when the board is full.
- **Player Switching:** Alternates between the two registered players after each valid move.
- **Console Display:** Dynamically displays available squares, `X`, and `O`, along with player-specific messages.

## 🏗️ Project Structure

- **`Program.cs`:** Entry point that creates and starts the game.
- **`Game.cs`:** Manages player registration, game flow, input validation, and turn switching.
- **`Board.cs`:** Manages the board, symbol placement, display, and win/draw detection.
- **`Player.cs`:** Stores player names and symbols using properties and a constructor.

## 🛠️ Built With

- **Language:** C#
- **Framework:** .NET (Console Application)
- **IDE:** Visual Studio Community
