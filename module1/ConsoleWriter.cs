namespace module1
{
    public static class ConsoleWriter
    {
        private static void WriteTriangleRow(int spaceCount, int asteriskCount)
        {
            Console.Write(new string(' ', spaceCount));
            Console.Write(new string('*', asteriskCount));
            Console.WriteLine();
        }

        public static void WriteTriangle(int topOffset, int asteriskCountIncrement, int height)
        {
            for (int i = 0; i < height; i++)
            {
                WriteTriangleRow(topOffset - i, asteriskCountIncrement * i + 1);
            }
        }

        public static void ConsoleWriteArray(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write((i < array.Length - 1) ? "{0}, " : "{0}", array[i].ToString());
            }
            Console.WriteLine();
        }
    }
}