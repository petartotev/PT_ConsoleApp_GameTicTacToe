namespace GameTicTacToe
{
    public class Game
    {
        private readonly Board _board = new();

        public void PlayTurn(char sign)
        {
            var (Row, Col) = GetInput(sign);
            _board.SetSlot(Row, Col, sign);
        }

        public (int Row, int Col) GetInput(char sign)
        {
            while (true)
            {
                Console.Write($" {sign}'s turn: ");
                var input = Console.ReadLine();

                if (!InputIsValid(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Invalid input!");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                var row = GetRowIndexFromInput(input);
                var col = GetColIndexFromInput(input);

                if (_board.SlotIsOccupied(row, col))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine(" Slot already occupied!");
                    Console.ForegroundColor = ConsoleColor.White;
                    continue;
                }

                return (row, col);
            }
        }

        public void PrintBoard()
        {
            Console.Clear();
            Console.WriteLine(_board.ToString());
        }

        private static bool InputIsValid(string input)
        {
            return !string.IsNullOrWhiteSpace(input)
                && input.Length == 2
                && (input.StartsWith("A", StringComparison.OrdinalIgnoreCase) || input.StartsWith("B", StringComparison.OrdinalIgnoreCase) || input.StartsWith("C", StringComparison.OrdinalIgnoreCase))
                && (input.EndsWith("1") || input.EndsWith("2") || input.EndsWith("3"));
        }

        private static int GetRowIndexFromInput(string input)
        {
            return input[1] switch
            {
                '1' => 0,
                '2' => 1,
                '3' => 2,
                _ => throw new ArgumentException()
            };
        }

        private static int GetColIndexFromInput(string input)
        {
            return input[0].ToString().ToUpper()[0] switch
            {
                'A' => 0,
                'B' => 1,
                'C' => 2,
                _ => throw new ArgumentException()
            };
        }

        public bool IsWon(char sign)
        {
            return _board.IsFinished(sign);
        }
    }
}
