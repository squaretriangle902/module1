namespace Module1
{
    public static class Task10
    {
        public static void Run()
        {
            int[,] array2d = new int[4, 3];
            RandomFiller.FillArray2dWithRandom(array2d, lowerBound: 0, upperBound: 10);
            ConsoleWriteArray2d(array2d);
            Console.WriteLine("Summ of elements on even positions: {0} ", SummOfElementsOnEvenPositions(array2d).ToString());
        }

        private static void ConsoleWriteArray2d(int[,] array2d)
        {
            for (int i = array2d.GetLowerBound(0); i <= array2d.GetUpperBound(0); i++)
            {
                for (int j = array2d.GetLowerBound(1); j <= array2d.GetUpperBound(1); j++)
                {
                    Console.Write("{0} ", array2d[i, j].ToString());
                }
                Console.WriteLine();
            }
        }

        private static int SummOfElementsOnEvenPositions(int[,] array2d)
        {
            int summ = 0;
            for (int i = array2d.GetLowerBound(0); i <= array2d.GetUpperBound(0); i++)
            {
                for (int j = array2d.GetLowerBound(1) + i % 2; j <= array2d.GetUpperBound(1); j += 2)
                {
                    summ += array2d[i, j];
                }
            }
            return summ;
        }
    }
}