namespace GameTicTacToe
{
    public static class ConsoleManager
    {
        public static void SetDefaultSettings()
        {
            Console.Title = "TicTacToe";
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetWindowSize(28, 28);
            Console.SetWindowPosition(0, 0);
            Console.SetBufferSize(28, 28);
            Console.CursorVisible = false;
        }
    }
}
