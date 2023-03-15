using Module2.Task1;
using Module2.Task6;
using System.ComponentModel;

namespace Module2.Task7
{
    internal static class Task7
    {
        private enum ConsoleCommand
        {
            write = 0,
            createCircle = 1,
            createLine = 2,
            createRound = 3,
            createRectangle = 4,
            createRing = 5,
            stop = 6,
        }

        internal static void Run()
        {
            Figure figure = null;
            ConsoleWriteCommandIDs();
            while (true)
            {
                ConsoleCommand consoleCommand = ReadConsoleCommand("Enter command ID: ", "Error: incorrect ID");
                switch (consoleCommand)
                {
                    case ConsoleCommand.stop: return;
                    case ConsoleCommand.write:
                        ExecuteWriteCommand(figure, "Figure is not created");
                    break;
                    default:
                        figure = ReadFigure(consoleCommand);
                    break;
                }
            }

        }

        private static void ConsoleWriteCommandIDs()
        {
            Console.WriteLine(
            "write = 0," + System.Environment.NewLine +
            "createCircle = 1," + System.Environment.NewLine +
            "createLine = 2," + System.Environment.NewLine +
            "createRound = 3," + System.Environment.NewLine +
            "createRectangle = 4," + System.Environment.NewLine +
            "createRing = 5," + System.Environment.NewLine +
            "stop = 6,");
        }

        private static void ExecuteWriteCommand(Figure figure, string figureNullMessage)
        {
            if (figure == null)
            {
                Console.WriteLine(figureNullMessage);
                return;
            }
            Console.WriteLine(figure.ToString());
        }

        private static ConsoleCommand ReadConsoleCommand(string consoleMessage = "", string errorMessage = "")
        {
            while (true)
            {
                Console.Write(consoleMessage);
                if (int.TryParse(Console.ReadLine(), out int commandID) &&
                    Enum.IsDefined(typeof(ConsoleCommand), commandID))
                {
                    return (ConsoleCommand)commandID;
                }
                Console.WriteLine(errorMessage);
            }
        }

        private static Figure ReadFigure(ConsoleCommand consoleCommand)
        {
            switch (consoleCommand) 
            {
                case ConsoleCommand.createCircle: return ReadCircleDialog();
                case ConsoleCommand.createLine: return ReadLineDialog();
                case ConsoleCommand.createRound: return ReadRoundDialog();
                case ConsoleCommand.createRectangle: return ReadRectangleDialog();
                case ConsoleCommand.createRing: return ReadRingDialog();
                default: return null;
            }
        }

        private static Ring ReadRingDialog()
        {
            ConsoleInputReader.TryReadPoint(out Point center, "Input point");
            ConsoleInputReader.TryReadDouble(out double outerRadius, "Input outer radius: ", "Incorrect input");
            ConsoleInputReader.TryReadDouble(out double innerRadius, "Input inner radius: ", "Incorrect input");
            return new Ring(center, outerRadius, innerRadius);
        }

        private static Rectangle ReadRectangleDialog()
        {
            ConsoleInputReader.TryReadPoint(out Point center, "Input point");
            ConsoleInputReader.TryReadDouble(out double width, "Input width", "Incorrect input");
            ConsoleInputReader.TryReadDouble(out double height, "Input height", "Incorrect input");
            return new Rectangle(center, width, height);
        }

        private static Round ReadRoundDialog()
        {
            if (TryReadCenterAndRadius(out Point center, out double radius))
            {
                return new Round(center, radius);
            }
            return null;
        }

        private static Line ReadLineDialog()
        {
            ConsoleInputReader.TryReadPoint(out Point a, "Input point A:");
            ConsoleInputReader.TryReadPoint(out Point b, "Input point B:");
            return new Line(a, b);
        }

        private static Circle ReadCircleDialog()
        {
            if(TryReadCenterAndRadius(out Point center, out double radius))
            {
                return new Circle(center, radius);
            }
            return null; 
        }

        private static bool TryReadCenterAndRadius(out Point center, out double radius)
        {
            radius = 0;
            return ConsoleInputReader.TryReadPoint(out center, "Input center: ") &&
                TryReadPositiveParameter(out radius, "Input radius: ", "error");
        }

        private static bool TryReadPositiveParameter(out double result, string inputMessage, string errorMessage,
            string nonPositiveError = "Error: must be positive")
        {
            if (ConsoleInputReader.TryReadDouble(out result, inputMessage, errorMessage) && result < 0)
            {
                Console.WriteLine(nonPositiveError);
                return false;
            }
            return true;
        }

    }
}
