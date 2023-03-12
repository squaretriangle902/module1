namespace module1
{
    public static class Task6
    {
        [Flags]
        private enum Emphasis 
        { 
            None = 0, 
            Bold = 1, 
            Italic = 1 << 1, 
            Underline = 1 << 2,
        };

        private enum Command
        {
            None = 0,
            Bold = 1,
            Italic = 2,
            Underline = 3,
        };

        public static void Execute()
        {
            Emphasis emphasis = Emphasis.None;
            while (true)
            {
                emphasis = ProgrammIteration(emphasis);
            }
        }

        private static Emphasis ProgrammIteration(Emphasis emphasis)
        {
            ConsoleWriteEmphasis(emphasis);
            ConsoleWriteEmphasises();
            Command command = ReadCommand("Enter command ID: ", "Incorrect command ID");
            emphasis = ExecuteCommand(emphasis, command);
            return emphasis;
        }

        private static Command ReadCommand(string consoleMessage = "", string errorMessage = "")
        {
            while (true)
            {
                if (ConsoleInputReader.TryReadInt(out int commandID, consoleMessage) && 
                   Enum.IsDefined(typeof(Command), commandID))
                {
                    return (Command)commandID;
                }
                Console.WriteLine(errorMessage);
            }
        }

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
                "      3: underline");

        }

        private static Emphasis ExecuteCommand(Emphasis emphasis, Command command)
        {
            switch (command)
            {
                case Command.Bold:
                    emphasis ^= Emphasis.Bold;
                    break;
                case Command.Italic:
                    emphasis ^= Emphasis.Italic;
                    break;
                case Command.Underline:
                    emphasis ^= Emphasis.Underline;
                    break;
                default:
                    break;
            }
            return emphasis;
        }
    }
}