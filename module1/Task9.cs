namespace module1
{
    public static class Task9
    {
        private static int SummOfNonNegative(int[] array)
        {
            int summ = 0;
            foreach (int item in array)
            {
                summ += item < 0 ? 0 : item;
            }
            return summ;
        }

        public static void Execute()
        {
            int[] array = new int[15];
            RandomFiller.FillArrayWithRandom(array, lowerBound: -10, upperBound: 10);
            ConsoleWriter.ConsoleWriteArray(array);
            Console.WriteLine("Summ of nonnegative: {0}", SummOfNonNegative(array).ToString());
        }
    }
}