class ConsoleWriter
{
    private static void WriteNSymbols(int n, char symbol)
    {
        for (int i = 0; i < n; i++)
        {
            Console.Write(symbol);
        }
    }

    private static void WriteTriangleRow(int spaceNumber, int asteriskNumber)
    {
        WriteNSymbols(spaceNumber, ' ');
        WriteNSymbols(asteriskNumber, '*');
        Console.WriteLine();
    }

    public static void WriteTriangle(int topOffset, int asteriskNumberIncrement, int height)
    {
        for (int i = 0; i < height; i++)
        {
            WriteTriangleRow(topOffset - i, asteriskNumberIncrement * i + 1);
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

class ConsoleInputReader
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

class RandomFiller
{
    private static Random random = new Random();

    public static void FillArrayWithRandom(int[] array, int lowerBound, int upperBound)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = random.Next(lowerBound, upperBound);
        }
    }

    public static void FillArray2dWithRandom(int[,] array2d, int lowerBound, int upperBound)
    {
        for (int i = array2d.GetLowerBound(0); i <= array2d.GetUpperBound(0); i++)
        {
            for (int j = array2d.GetLowerBound(1); j <= array2d.GetUpperBound(1); j++)
            {
                array2d[i, j] = random.Next(lowerBound, upperBound);
            }
        }
    }

    public static void FillArray3dWithRandom(int[,,] array3d, int lowerBound, int upperBound)
    {
        for (int i = array3d.GetLowerBound(0); i <= array3d.GetUpperBound(0); i++)
        {
            for (int j = array3d.GetLowerBound(1); j <= array3d.GetUpperBound(1); j++)
            {
                for (int k = array3d.GetLowerBound(2); k <= array3d.GetUpperBound(2); k++)
                {
                    array3d[i, j, k] = random.Next(lowerBound, upperBound);
                }
            }
        }
    }
}

class Task1
{
    private static bool PrintErrorIfNonPositiveInt(int result)
    {
        if (result <= 0)
        {
            Console.WriteLine("Incorrect input: nonpositive integer");
            return true;
        }
        return false;
    }

    private static int ReadPositiveIntUntilCorrect(string consoleMessage)
    {
        int result = 0;
        while (!ConsoleInputReader.TryReadInt(out result, consoleMessage) || PrintErrorIfNonPositiveInt(result)) ;
        return result;
    }

    public static void Execute()
    {
        int a = ReadPositiveIntUntilCorrect("Enter a: ");
        int b = ReadPositiveIntUntilCorrect("Enter b: ");
        Console.WriteLine("Area of rectangle: {0}", (a * b).ToString());
    }

}

class Task2
{
    private static void WriteTriangle(int height)
    {
        ConsoleWriter.WriteTriangle(topOffset: 0, asteriskNumberIncrement: 1, height);
    }
    public static void Execute()
    {
        int height = ConsoleInputReader.ReadIntUntilCorrect("Input triangle height: ");
        WriteTriangle(height);
    }
}

class Task3
{
    private static void WriteTriangle(int height)
    {
        ConsoleWriter.WriteTriangle(height - 1, asteriskNumberIncrement: 2, height);
    }
    public static void Execute()
    {
        int height = ConsoleInputReader.ReadIntUntilCorrect("Input triangle height: ");
        WriteTriangle(height);
    }
}

class Task4
{
    private static void WriteTriangles(int trianglesNumber)
    {
        for (int i = 1; i <= trianglesNumber + 1; i++)
        {
            ConsoleWriter.WriteTriangle(trianglesNumber, asteriskNumberIncrement: 2, i);
        }
    }

    public static void Execute()
    {
        int trianglesNumber = ConsoleInputReader.ReadIntUntilCorrect("Input number of triangles: ");
        WriteTriangles(trianglesNumber);

    }
}

class Task5
{
    private static bool FilterCondition(int number)
    {
        return number % 3 == 0 || number % 5 == 0;
    }

    private static int CalculateSummOfSatisfyingNumbers(int strictUpperBound)
    {
        int summ = 0;
        for (int number = 0; number < strictUpperBound; number++)
        {
            if (FilterCondition(number))
            {
                summ += number;
            }
        }
        return summ;
    }

    public static void Execute()
    {
        Console.WriteLine(CalculateSummOfSatisfyingNumbers(strictUpperBound: 1000).ToString());
    }
}

class Task6
{
    [Flags]
    private enum Emphasis { None = 0, Bold = 1, Italic = 2, Underline = 4 };

    private static void ConsoleWriteEmphasis(Emphasis emphasis)
    {
        Console.WriteLine("Current emphasis: {0}", emphasis.ToString());
    }

    private static void ConsoleWriteEmphasises()
    {
        Console.WriteLine(
            "Enter:" + System.Environment.NewLine +
            "      1: bold" + System.Environment.NewLine +
            "      2: italic" + System.Environment.NewLine +
            "      3: underline" + System.Environment.NewLine);

    }

    private static Emphasis ExecuteCommand(Emphasis emphasis, int commandNumber)
    {
        switch (commandNumber)
        {
            case 1:
                emphasis ^= Emphasis.Bold;
                break;
            case 2:
                emphasis ^= Emphasis.Italic;
                break;
            case 3:
                emphasis ^= Emphasis.Underline;
                break;
            default:
                break;
        }
        return emphasis;
    }

    private static Emphasis ProgrammIteration(Emphasis emphasis)
    {
        ConsoleWriteEmphasis(emphasis);
        ConsoleWriteEmphasises();
        int commandNumber = ConsoleInputReader.ReadIntUntilCorrect();
        emphasis = ExecuteCommand(emphasis, commandNumber);
        return emphasis;
    }

    public static void Execute()
    {
        Emphasis emphasis = Emphasis.None;
        while (true)
        {
            emphasis = ProgrammIteration(emphasis);
        }
    }
}

class Task7
{
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

    public static void Execute()
    {
        int[] array = new int[15];
        RandomFiller.FillArrayWithRandom(array, lowerBound: -10, upperBound: 10);
        ConsoleWriter.ConsoleWriteArray(array);
        BubleSort(array);
        ConsoleWriter.ConsoleWriteArray(array);
        ConsoleWriteSortedArrayMinAndMax(array);
    }
}

class Task8
{
    private static void ConsoleWriteArray3d(int[,,] array3d)
    {
        for (int i = array3d.GetLowerBound(0); i <= array3d.GetUpperBound(0); i++)
        {
            for (int j = array3d.GetLowerBound(1); j <= array3d.GetUpperBound(1); j++)
            {
                for (int k = array3d.GetLowerBound(2); k <= array3d.GetUpperBound(2); k++)
                {
                    Console.WriteLine("array[{0}, {1}, {2}] = {3}", i, j, k, array3d[i, j, k]);
                }
            }
        }
        Console.WriteLine();
    }

    private static void Array3dFill(int[,,] array3d, int number)
    {
        for (int i = array3d.GetLowerBound(0); i <= array3d.GetUpperBound(0); i++)
        {
            for (int j = array3d.GetLowerBound(1); j <= array3d.GetUpperBound(1); j++)
            {
                for (int k = array3d.GetLowerBound(2); k <= array3d.GetUpperBound(2); k++)
                {
                    array3d[i, j, k] = number;
                }
            }
        }
    }

    public static void Execute()
    {
        int[,,] array3d = new int[2, 3, 4];
        RandomFiller.FillArray3dWithRandom(array3d, lowerBound: -10, upperBound: 10);
        ConsoleWriteArray3d(array3d);
        Array3dFill(array3d, number: 0);
        ConsoleWriteArray3d(array3d);
    }
}

class Task9
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

class Task10
{
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

    public static void Execute()
    {
        int[,] array2d = new int[4, 3];
        RandomFiller.FillArray2dWithRandom(array2d, lowerBound: 0, upperBound: 10);
        ConsoleWriteArray2d(array2d);
        Console.WriteLine("Summ of elements on even positions: {0} ", SummOfElementsOnEvenPositions(array2d).ToString());
    }
}

class Programm
{
    public static void Main()
    {
        Task10.Execute();
    }
}