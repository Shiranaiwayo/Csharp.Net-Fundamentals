using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe;

public interface IUI
{
    void Write(string message);
    void WriteLine(string message);
    string? ReadInput();
    void Clear();
}
