using System.Text;

namespace GameTicTacToe
{
    public class Program
    {
        public static void Main()
        {
            PlayIntro();

            var gameCounter = 0;

            while (true)
            {
                var game = new Game();
                gameCounter++;

                Console.Clear();
                Console.WriteLine($"\n Game #{gameCounter} begins!");
                Thread.Sleep(2000);

                for (int i = 1; i <= 9; i++)
                {
                    var sign = i % 2 == 0 ? 'O' : 'X';
                    
                    game.PrintBoard();
                    game.PlayTurn(sign);
                    game.PrintBoard();

                    if (game.IsWon(sign))
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($" Congrats! '{sign}' won!");
                        Thread.Sleep(3000);
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    }

                    if (i == 9)
                    {
                        Console.WriteLine($" Game is even.");
                        Thread.Sleep(3000);
                    }
                }

                Console.Write(" One more game? [Y/n]: ");
                var input = Console.ReadKey();
                if (input.Key != ConsoleKey.Y && input.Key != ConsoleKey.Enter)
                {
                    Console.WriteLine("\n Goodbye...");
                    Thread.Sleep(3000);
                    Environment.Exit(0);
                }
                Console.WriteLine("\n Let's play one more!");
                Thread.Sleep(3000);
            }
        }

        public static void PlayIntro()
        {
            ConsoleManager.SetDefaultSettings();
            Thread.Sleep(300);
            Console.Write("             .");
            Thread.Sleep(400);
            Console.Write(".");
            Thread.Sleep(500);
            Console.Write(".");
            Thread.Sleep(600);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n");
            var tic = new StringBuilder()
                .AppendLine("      |_   _||_| /  _\\")
                .AppendLine("        | |  | | | |_ ")
                .AppendLine("        |_|  |_| \\___/").ToString();
            Console.WriteLine(tic);
            Thread.Sleep(700);
            var tac = new StringBuilder()
                .AppendLine("     |_   _|/ _ \\ /  _\\")
                .AppendLine("       | | / ___ \\| |_")
                .AppendLine("       |_| |_| |_|\\___/").ToString();
            Console.WriteLine(tac);
            Thread.Sleep(800);
            var toe = new StringBuilder()
                .AppendLine("     |_   _|/   \\ | __|")
                .AppendLine("       | | (  |  )| _|")
                .AppendLine("       |_|  \\___/ |___|").ToString();
            Console.WriteLine(toe);
            Thread.Sleep(2000);
            Console.Clear();
        }
    }
}