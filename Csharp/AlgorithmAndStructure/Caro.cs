namespace AlgorithmAndStructure
{
    class TicTocToe
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int flag;
        static int player = 1;
        private static int checkWin()
        {
            #region checking for drawn
            if (arr[1] == '1' && arr[2] == '2' && arr[3] == '3' && arr[4] == '4' && arr[5] == '5' && arr[6] == '6' && arr[7] == '7' && arr[8] == '8' && arr[9] == '9')
                return 1;
            else
                return 0;
            #endregion
        }
        public static void Board()
        {
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[1], arr[2], arr[3]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[4], arr[5], arr[6]);
            Console.WriteLine("_____|_____|_____ ");
            Console.WriteLine("     |     |      ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", arr[7], arr[8], arr[9]);
            Console.WriteLine("     |     |      ");
        }
    }
}