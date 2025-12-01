using System.Text;

namespace TrafficLightWithEncapsulation
{
    internal class TrafficLightConsole
    {
        public static void Show(bool red, bool yellow, bool green)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("┏━┓");
            DrawLine(red ? ConsoleColor.Red : ConsoleColor.Black);
            DrawLine(yellow ? ConsoleColor.Yellow : ConsoleColor.Black);
            DrawLine(green ? ConsoleColor.Green : ConsoleColor.Black);
            Console.WriteLine("┗━┛");
        }

        private static void DrawLine(ConsoleColor color)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("┃");
            Console.ForegroundColor = color;
            Console.Write("O");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("┃");
        }
    }
}