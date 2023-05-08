using System.Text;

namespace GameTicTacToe
{
    public class Board
    {
        private char[][] _field = new char[][] { new char[] { ' ', ' ', ' ' }, new char[] { ' ', ' ', ' ' }, new char[] { ' ', ' ', ' ' } };

        public Board()
        {

        }

        public void ResetField()
        {
            _field = new char[][] { new char[] { ' ', ' ', ' ' }, new char[] { ' ', ' ', ' ' }, new char[] { ' ', ' ', ' ' } };
        }

        public override string ToString()
        {
            return new StringBuilder()
                .AppendLine("\n        A     B     C")
                .AppendLine("     |     |     |     |")
                .AppendLine($"    1|  {_field[0][0]}  |  {_field[0][1]}  |  {_field[0][2]}  |1")
                .AppendLine("     |_____|_____|_____|")
                .AppendLine("     |     |     |     |")
                .AppendLine($"    2|  {_field[1][0]}  |  {_field[1][1]}  |  {_field[1][2]}  |2")
                .AppendLine("     |_____|_____|_____|")
                .AppendLine("     |     |     |     |")
                .AppendLine($"    3|  {_field[2][0]}  |  {_field[2][1]}  |  {_field[2][2]}  |3")
                .AppendLine("     |_____|_____|_____|")
                .AppendLine("        A     B     C")
                .ToString();
        }

        public bool SlotIsOccupied(int row, int col)
        {
            return _field[row][col] != ' ';
        }

        public char GetSlot(int row, int col)
        {
            return _field[row][col];
        }

        public void SetSlot(int row, int col, char input)
        {
            _field[row][col] = input;
        }

        public bool IsFinished(char sign)
        {
            return (_field[0][0] == sign && _field[0][1] == sign && _field[0][2] == sign)
                || (_field[1][0] == sign && _field[1][1] == sign && _field[1][2] == sign)
                || (_field[2][0] == sign && _field[2][1] == sign && _field[2][2] == sign)
                || (_field[0][0] == sign && _field[1][0] == sign && _field[2][0] == sign)
                || (_field[0][1] == sign && _field[1][1] == sign && _field[2][1] == sign)
                || (_field[0][2] == sign && _field[1][2] == sign && _field[2][2] == sign)
                || (_field[0][0] == sign && _field[1][1] == sign && _field[2][2] == sign)
                || (_field[0][2] == sign && _field[1][1] == sign && _field[2][0] == sign);
        }
    }
}
