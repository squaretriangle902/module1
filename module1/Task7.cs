namespace module1
{
    public static class Task7
    {
        public static void Execute()
        {
            int[] array = new int[15];
            RandomFiller.FillArrayWithRandom(array, lowerBound: -10, upperBound: 10);
            ConsoleWriter.ConsoleWriteArray(array);
            BubleSort(array);
            ConsoleWriter.ConsoleWriteArray(array);
            ConsoleWriteSortedArrayMinAndMax(array);
        }
        private static void SwapWithNextIfGreater(int[] array, int i)
        {
            if (array[i] > array[i + 1])
            {
                (array[i], array[i + 1]) = (array[i + 1], array[i]);
            }
        }
        private static void BubbleSortIteration(int[] array, int bound)
        {
            for (int i = 0; i < bound; i++)
            {
                SwapWithNextIfGreater(array, i);
            }
        }

        private static void BubleSort(int[] array)
        {
            for (int i = array.Length - 1; i > 2; i--)
            {
                BubbleSortIteration(array, i);
            }
        }

        private static void ConsoleWriteSortedArrayMinAndMax(int[] array)
        {
            Console.WriteLine("min: {0}; max: {1}", array.First().ToString(), array.Last().ToString());
        }
    }
}