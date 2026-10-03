namespace Tic_Tac_Toe;

internal class Program
{
    static void Main(string[] args)
    {
        string[] board = { " ", " ", " ", " ", " ", " ", " ", " ", " " };

        var currentPlayer = 1;
        var gameOver = false;

        while (!gameOver)
        {
            DisplayBoard(board);
            var symbol = GetSymbol(currentPlayer);

            Console.Write($"Player {currentPlayer}, choose a square (1-9): ");
            
            var index = GetValidMove(board);

            board[index] = symbol;

            if (CheckWinner(board, symbol))
            {
                gameOver = true;
                //Show winning board
                DisplayBoard(board);
                Console.WriteLine($"\nPlayer {currentPlayer} won!");
            }
            else if (CheckDraw(board))
            {
                gameOver = true;
                //Show final board
                DisplayBoard(board);
                Console.WriteLine("\nIt's a draw!");
            }
            else
            {
                currentPlayer = SwitchPlayer(currentPlayer);
            }
        }
    }
    static void DisplayBoard(string[] board)
    {
        Console.Clear();
        Console.WriteLine("Tic-Tac-Toe\n");
        for (var square = 0; square < board.Length; square++)
        {
            if (board[square] == " ")
            {
                Console.Write($" {square + 1} ");
            }
            else
            {
                Console.Write($" {board[square]} ");
            }

            if ((square + 1) % 3 != 0)
            {
                Console.Write("|");
            }

            if ((square + 1) % 3 == 0 && square < board.Length - 1)
            {
                Console.WriteLine("\n---+---+---");
            }
        }
        Console.WriteLine("\n");
    }
    static int ValidateInput()
    {
        while (true)
        {
            var input = Console.ReadLine();

            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 9)
            {
                return choice;
            }

            Console.Write("Please enter a number between 1 and 9: ");
        }
    }
    static int GetValidMove(string[] board)
    {
        while (true)
        {
            var choice = ValidateInput();
            var index = choice - 1;

            if (board[index] == " ")
            {
                return index;
            }

            Console.Write("That square is occupied! Try again: ");
        }
    }
    static string GetSymbol(int currentPlayer)
    {
        return currentPlayer == 1 ? "X" : "O";
    }
    static bool CheckWinner(string[] board, string symbol)
    {
        return
            (board[0] == symbol && board[1] == symbol && board[2] == symbol) ||
            (board[3] == symbol && board[4] == symbol && board[5] == symbol) ||
            (board[6] == symbol && board[7] == symbol && board[8] == symbol) ||
            (board[0] == symbol && board[3] == symbol && board[6] == symbol) ||
            (board[1] == symbol && board[4] == symbol && board[7] == symbol) ||
            (board[2] == symbol && board[5] == symbol && board[8] == symbol) ||
            (board[0] == symbol && board[4] == symbol && board[8] == symbol) ||
            (board[2] == symbol && board[4] == symbol && board[6] == symbol);
    }
    static bool CheckDraw(string[] board)
    {
        foreach (string square in board)
        {
            if (square == " ")
            {
                return false;
            }
        }
        return true;
    }
    static int SwitchPlayer(int currentPlayer)
    {
        return currentPlayer == 1 ? 2 : 1;
    }
}


