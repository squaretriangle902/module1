namespace Module2.Task4
{
    internal static class Task4
    {
        internal static void ConsoleWriteMyString(MyString myString)
        {
            for (int i = 0; i < myString.Size; i++)
            {
                Console.Write(myString[i]);
            }
            Console.WriteLine();
        }

        internal static void Run()
        {
            MyString[] myStrings = { new MyString("Hello "), new MyString("World"), new MyString("!") };
            ConsoleWriteMyString(new MyString("Hello ") + new MyString("World"));
            ConsoleWriteMyString(MyString.Concat(myStrings));
        }

    }
}
