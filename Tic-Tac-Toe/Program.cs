namespace Tic_Tac_Toe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] board = { " ", " ", " ", " ", " ", " ", " ", " ", " " };

            var currentPlayer = 1;
            var gameOver = false;

            while (!gameOver)
            {
                Console.Clear();

                Console.WriteLine("Tic-Tac-Toe\n");
                //Shows board
                for (int i = 0; i < board.Length; i++)
                {
                    Console.Write($" {board[i]} ");

                    if ((i + 1) % 3 != 0)
                    {
                        Console.Write("|");
                    }

                    if ((i + 1) % 3 == 0 && i < board.Length - 1)
                    {
                        Console.WriteLine("\n---+---+---");
                    }
                }

                Console.WriteLine("\n");

                //Who is playing?
                string symbol;

                if (currentPlayer == 1)
                {
                    symbol = "X";
                }
                else
                {
                    symbol = "O";
                }

                Console.Write($"Player {currentPlayer}, choose a square (1-9): ");
                string input = Console.ReadLine();

                if (!int.TryParse(input, out int choice))
                {
                    Console.WriteLine("That is not a number.");
                    Console.ReadKey();
                    continue;
                }

                if (choice < 1 || choice > 9)
                {
                    Console.WriteLine("That is not a number between 1 and 9.");
                    Console.ReadKey();
                    continue;
                }

                int index = choice - 1;

                if (board[index] != " ")
                {
                    Console.WriteLine("That square is occupied!");
                    Console.ReadKey();
                    continue;
                }

                board[index] = symbol;

                if (
                    // Rows
                    (board[0] == symbol && board[1] == symbol && board[2] == symbol) ||
                    (board[3] == symbol && board[4] == symbol && board[5] == symbol) ||
                    (board[6] == symbol && board[7] == symbol && board[8] == symbol) ||
                    // Columns
                    (board[0] == symbol && board[3] == symbol && board[6] == symbol) ||
                    (board[1] == symbol && board[4] == symbol && board[7] == symbol) ||
                    (board[2] == symbol && board[5] == symbol && board[8] == symbol) ||
                    // Diagonals
                    (board[0] == symbol && board[4] == symbol && board[8] == symbol) ||
                    (board[2] == symbol && board[4] == symbol && board[6] == symbol)
                   )
                {
                    gameOver = true;

                    //Show winning board
                    Console.Clear();

                    for (int i = 0; i < board.Length; i++)
                    {
                        Console.Write($" {board[i]} ");

                        if ((i + 1) % 3 != 0)
                        {
                            Console.Write("|");
                        }

                        if ((i + 1) % 3 == 0 && i < board.Length - 1)
                        {
                            Console.WriteLine("\n---+---+---");
                        }
                    }

                    Console.WriteLine($"\n\nPlayer {currentPlayer} won!");
                }
                else
                {
                    //check if all squares are occupied
                    bool draw = true;

                    foreach (string square in board)
                    {
                        if (square == " ")
                        {
                            draw = false;
                            break;
                        }
                    }

                    if (draw)
                    {
                        gameOver = true;
                        //Show final board
                        Console.Clear();
                        for (int i = 0; i < board.Length; i++)
                        {
                            Console.Write($" {board[i]} ");

                            if ((i + 1) % 3 != 0)
                            {
                                Console.Write("|");
                            }

                            if ((i + 1) % 3 == 0 && i < board.Length - 1)
                            {
                                Console.WriteLine("\n---+---+---");
                            }
                        }
                        Console.WriteLine("\n\nIt's a draw!");
                    }
                    else
                    {
                        //Switch player
                        if (currentPlayer == 1)
                        {
                            currentPlayer = 2;
                        }
                        else
                        {
                            currentPlayer = 1;
                        }
                    }
                }
            }
        }
    }
}
