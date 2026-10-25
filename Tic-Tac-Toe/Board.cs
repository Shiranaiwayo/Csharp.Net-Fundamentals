namespace Tic_Tac_Toe;

public class Board
{
    private readonly string[] _squares =
    {
        " ", " ", " ",
        " ", " ", " ",
        " ", " ", " "
    };
    public void Display()
    {
        Console.Clear();
        Console.WriteLine("""
            ***********
            Tic-Tac-Toe
            ***********
            """);
        for (var square = 0; square < _squares.Length; square++)
        {
            if (_squares[square] == " ")
            {
                Console.Write($" {square + 1} ");
            }
            else
            {
                Console.Write($" {_squares[square]} ");
            }

            if ((square + 1) % 3 != 0)
            {
                Console.Write("|");
            }

            if ((square + 1) % 3 == 0 && square < _squares.Length - 1)
            {
                Console.WriteLine("\n---+---+---");
            }
        }
        Console.WriteLine("\n");
    }
    public void PlaceSymbol(int index, string symbol)
    {
        if (index < 0 || index >= _squares.Length)
            throw new ArgumentOutOfRangeException(nameof(index));

        if (symbol != "X" && symbol != "O")
            throw new ArgumentException("Symbol must be X or O.");

        if (!IsEmpty(index))
            throw new InvalidOperationException("Square is already occupied.");

        _squares[index] = symbol;
    }
    public bool IsEmpty(int index)
    {
        return _squares[index] == " ";
    }
    public bool CheckWinner(string symbol)
    {
        return
            (_squares[0] == symbol && _squares[1] == symbol && _squares[2] == symbol) ||
            (_squares[3] == symbol && _squares[4] == symbol && _squares[5] == symbol) ||
            (_squares[6] == symbol && _squares[7] == symbol && _squares[8] == symbol) ||
            (_squares[0] == symbol && _squares[3] == symbol && _squares[6] == symbol) ||
            (_squares[1] == symbol && _squares[4] == symbol && _squares[7] == symbol) ||
            (_squares[2] == symbol && _squares[5] == symbol && _squares[8] == symbol) ||
            (_squares[0] == symbol && _squares[4] == symbol && _squares[8] == symbol) ||
            (_squares[2] == symbol && _squares[4] == symbol && _squares[6] == symbol);
    }

    public bool CheckDraw()
    {
        foreach (string square in _squares)
        {
            if (square == " ")
            {
                return false;
            }
        }
        return true;
    }

}


