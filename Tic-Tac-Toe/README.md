# 🎮 C# Console Tic-Tac-Toe

A simple two-player console-based Tic-Tac-Toe game built while learning arrays, loops, conditionals, input validation, and game logic in C#. Players take turns choosing squares from 1–9, with the game checking for a winner or a draw after each move.

## 🚀 Key Logic & Features

* **Board:** Uses a `string[]` with 9 positions to represent the game board.
* **Players:** Player 1 uses `X`, Player 2 uses `O`.
* **Input:** Validates that the player enters a number between `1–9`.
* **Moves:** Prevents players from selecting occupied squares.
* **Win Check:** Checks rows, columns, and diagonals after each move.
* **Draw Check:** Detects when all 9 squares are occupied without a winner.
* **Turn Switching:** Switches between Player 1 and Player 2 after each valid move.
* **Game Loop:** Continues until a player wins or the game ends in a draw.

## 🛠️ Built With

* **Language:** C#
* **Framework:** .NET (Console Application)
* **IDE:** Visual Studio Community
