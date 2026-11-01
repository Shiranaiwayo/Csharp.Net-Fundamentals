using System;
using System.Collections.Generic;
using System.Text;

namespace Tic_Tac_Toe;

public class TestUI : IUI
{
    private readonly Queue<string> _inputs;
    public List<string> Output { get; } = new();

    public TestUI(params string[] inputs)
    {
        _inputs = new Queue<string>(inputs);
    }
    public void Write(string message)
    {
        Output.Add(message);
    }
    public void WriteLine(string message)
    {
        Output.Add(message);
    }
    public string? ReadInput()
    {
        if (_inputs.Count == 0)
            throw new InvalidOperationException("No test inputs left.");

        return _inputs.Dequeue();
    }
    public void Clear()
    {
        //No console to clear during testing
    }
}
