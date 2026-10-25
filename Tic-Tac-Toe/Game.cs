namespace Tic_Tac_Toe;

public class Game
{
    private readonly Board _board = new();
    private Player _player1;
    private Player _player2;
    private Player _currentPlayer;

    private Player RegisterPlayer(int number, string symbol)
    {
        string? name;

        do
        {
            Console.Write($"Enter name for Player {number} ({symbol}): ");
            name = Console.ReadLine()?.Trim();
        } while (string.IsNullOrWhiteSpace(name));
        return new Player(name, symbol);
    }

    public void Start()
    {
        _player1 = RegisterPlayer(1, "X");
        _player2 = RegisterPlayer(2, "O");
        _currentPlayer = _player1;

        var gameOver = false;

        while (!gameOver)
        {
            _board.Display();
            var symbol = _currentPlayer.Symbol;

            Console.Write($"{_currentPlayer.Name} ({_currentPlayer.Symbol}), choose a square (1-9): ");

            var index = GetValidMove();

            _board.PlaceSymbol(index, symbol);

            if (_board.CheckWinner(symbol))
            {
                gameOver = true;
                _board.Display();
                Console.WriteLine($"\n{_currentPlayer.Name} won!");
            }
            else if (_board.CheckDraw())
            {
                gameOver = true;
                _board.Display();
                Console.WriteLine("\nIt's a draw!");
            }
            else
            {
                SwitchPlayer();
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
    private int GetValidMove()
    {
        while (true)
        {
            var choice = ValidateInput();
            var index = choice - 1;

            if (_board.IsEmpty(index))
            {
                return index;
            }
            Console.Write("That square is occupied! Try again: ");
        }
    }

    private void SwitchPlayer()
    {
        _currentPlayer = _currentPlayer == _player1 ? _player2 : _player1;
    }
}

