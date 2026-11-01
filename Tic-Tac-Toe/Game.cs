namespace Tic_Tac_Toe;

public class Game
{
    private readonly Board _board = new();
    private readonly IUI _ui;
    private Player _player1;
    private Player _player2;
    private Player _currentPlayer;
    private bool _playAgainstComputer;
    private readonly Random _random = new();

    public Game(IUI ui)
    {
        _ui = ui;
    }

    private void SelectGameMode()
    {
        while (true)
        {
            _ui.WriteLine("1. Two players");
            _ui.WriteLine("2. Play against computer");
            _ui.Write("Choose game mode: ");

            var input = _ui.ReadInput();

            if (input == "1" || input == "2")
            {
                _playAgainstComputer = input == "2";
                return;
            }

            _ui.WriteLine("Please choose 1 or 2.");
        }
    }
 
    private Player RegisterPlayer(int number, string symbol)
    {
        string? name;
        do
        {
            _ui.Write($"Enter name for Player {number} ({symbol}): ");
            name = _ui.ReadInput()?.Trim();
        } while (string.IsNullOrWhiteSpace(name));
        return new Player(name, symbol);
    }

    public void Start()
    {
        SelectGameMode();

        _player1 = RegisterPlayer(1, "X");
        _player2 = _playAgainstComputer ? new Player("Computer", "O") : RegisterPlayer(2, "O");
        _currentPlayer = _player1;

        var gameOver = false;

        while (!gameOver)
        {
            _ui.Clear();
            _ui.WriteLine(_board.GetDisplay());

            var symbol = _currentPlayer.Symbol;

            int index;

            if (_playAgainstComputer && _currentPlayer == _player2)
            {
                index = GetComputerMove();
            }
            else
            {
                _ui.Write($"{_currentPlayer.Name} ({_currentPlayer.Symbol}), choose a square (1-9): ");
                index = GetValidMove();
            }

            _board.PlaceSymbol(index, symbol);

            if (_board.CheckWinner(symbol))
            {
                gameOver = true;
                _ui.Clear();
                _ui.WriteLine(_board.GetDisplay());
                _ui.WriteLine($"\n{_currentPlayer.Name} won!");
            }
            else if (_board.CheckDraw())
            {
                gameOver = true;
                _ui.Clear();
                _ui.WriteLine(_board.GetDisplay());
                _ui.WriteLine("\nIt's a draw!");
            }
            else
            {
                SwitchPlayer();
            }
        }
    }
    private int GetComputerMove()
    {
        int index;

        do
        {
            index = _random.Next(0, 9);
        }
        while (!_board.IsEmpty(index));

        return index;
    }

    private int ValidateInput()
    {
        while (true)
        {
            var input = _ui.ReadInput();

            if (int.TryParse(input, out int choice) && choice >= 1 && choice <= 9)
            {
                return choice;
            }

            _ui.Write("Please enter a number between 1 and 9: ");
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
            _ui.Write("That square is occupied! Try again: ");
        }
    }

    private void SwitchPlayer()
    {
        _currentPlayer = _currentPlayer == _player1 ? _player2 : _player1;
    }
}

