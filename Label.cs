using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows
{
    class Label : View
    {
        private string text;

        public Label(string text, int x, int y, int width, int height) : base(x, y, width, height)
        {
            this.text = text;
        }

        public void SetText(string text)
        {
            this.text = text;
        }

        public override void Draw()
        {
            DrawBorders();
            Console.SetCursorPosition(x + 1, y + 1);
            Console.Write(text.Substring(0, Math.Min(width - 1, text.Length)));
        }
    }
}
