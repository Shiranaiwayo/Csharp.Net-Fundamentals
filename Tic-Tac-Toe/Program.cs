namespace Tic_Tac_Toe;

internal class Program
{
    static void Main(string[] args)
    {
        var ui = new ConsoleUI();
        var game = new Game(ui);
        game.Start();

    }

}

