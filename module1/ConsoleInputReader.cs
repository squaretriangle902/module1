namespace Module1
{
    public static class ConsoleInputReader
    {
        public static bool TryReadInt(out int result, string consoleMessage)
        {
            Console.Write(consoleMessage);
            return int.TryParse(Console.ReadLine(), out result);
        }

        public static int ReadIntUntilCorrect(string consoleMessage = "")
        {
            int result = 0;
            while (!TryReadInt(out result, consoleMessage)) ;
            return result;
        }
    }
}
