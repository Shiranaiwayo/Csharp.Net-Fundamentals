using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe;

public class ConsoleUI : IUI
{
    public void Write(string message)
    {
        Console.Write(message);
    }

    public void WriteLine(string message)
    {
        Console.WriteLine(message);
    }

    public string? ReadInput()
    {
        return Console.ReadLine();
    }

    public void Clear()
    {
        Console.Clear();
    }
}
