namespace Tic_Tac_Toe;

public class Game
{
    private Board _board = new Board();
    private int _currentPlayer = 1;

    public void Start()
    {
        var gameOver = false;

        while (!gameOver)
        {
            _board.Display();
            var symbol = GetSymbol(_currentPlayer);

            Console.Write($"Player {_currentPlayer}, choose a square (1-9): ");

            var index = GetValidMove(_board);

            _board.PlaceSymbol(index, symbol);

            if (_board.CheckWinner(symbol))
            {
                gameOver = true;
                _board.Display();
                Console.WriteLine($"\nPlayer {_currentPlayer} won!");
            }
            else if (_board.CheckDraw())
            {
                gameOver = true;
                _board.Display();
                Console.WriteLine("\nIt's a draw!");
            }
            else
            {
                _currentPlayer = SwitchPlayer(_currentPlayer);
            }
        }
    }

    private int ValidateInput()
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

    private int GetValidMove(Board board)
    {
        while (true)
        {
            var choice = ValidateInput();
            var index = choice - 1;

            if (board.IsEmpty(index))
            {
                return index;
            }

            Console.Write("That square is occupied! Try again: ");
        }
    }

    private string GetSymbol(int currentPlayer)
    {
        return currentPlayer == 1 ? "X" : "O";
    }

    private int SwitchPlayer(int currentPlayer)
    {
        return currentPlayer == 1 ? 2 : 1;
    }
}

