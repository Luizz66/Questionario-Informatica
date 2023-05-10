using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Informática
{
    public static class Ferramentas
    {
        public static void ColorLine(string text, ConsoleColor color)
        {
            Console.ForegroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }
        public static void ColorBack(string text, ConsoleColor color)
        {
            Console.BackgroundColor = color;
            Console.Write(text);
            Console.ResetColor();
        }
    }
}
