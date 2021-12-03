using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public static class ConsoleHelp
    {

        public static void ColorWriteLine(string s, string color)
        {
            switch (color)
            {
                case "blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case "yellow":
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case "green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "white":
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Gray;
                    break;
            }
            Console.WriteLine(s);
            Console.ResetColor();
        }

        //clears the last line of text in the console
       public static void ClearLastConsoleLine()
        {
            Console.SetCursorPosition(0, Console.CursorTop - 1);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, Console.CursorTop);
        }
        //clears X lines of text from the console
        //accepts amount of lines to clear as parameter
        public static void ClearXConsoleLines(int lines)
        {

            for (int j = 0; j < lines; j++)
            {
                Console.SetCursorPosition(0, Console.CursorTop - 1);
                Console.Write(new string(' ', Console.WindowWidth));
                Console.SetCursorPosition(0, Console.CursorTop);
            }
        }
        public static ConsoleKeyInfo GetMenuChoice()
        {
            ConsoleKeyInfo input = Console.ReadKey(true);
            return input;
        }
    }
}
