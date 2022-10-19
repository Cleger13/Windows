using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows
{
    static class Drawer
    {
        public static void DrawVerticalLine(int x, int y, int length)
        {
            for (int i = 0; i < length; i++)
            {
                DrawAtPosition(x, y + i, '║');
            }
        }

        public static void DrawHorizontalLine(int x, int y, int length)
        {
            for (int i = 0; i < length; i++)
            {
                DrawAtPosition(x + i, y, '═');
            }
        }

        public static void DrawAtPosition(int x, int y, char symbol)
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
