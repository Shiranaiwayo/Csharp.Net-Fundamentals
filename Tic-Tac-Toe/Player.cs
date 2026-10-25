using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe;

internal class Player
{
    public string Name { get; }
    public string Symbol { get; }

    public Player(string name, string symbol)
    {
        if (string.IsNullOrWhiteSpace(name))
            throw new ArgumentException("Name cannot be empty.");

        Name = name.Trim();
        Symbol = symbol;
    }
}
