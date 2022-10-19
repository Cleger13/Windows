using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows
{
    class Button : Interactable
    {
        private Action onClick;
        public string text = "Button";

        public Button(string text, Action click, int x, int y, int width, int height) : base(x, y, width, height)
        {
            this.text = text;
            onClick = click;
        }

        public override void Interact()
        {
            onClick?.Invoke();
        }

        public void SetText(string text)
        {
            this.text = text;
        }

        public override void Draw()
        {
            DrawBorders();
            Console.SetCursorPosition(x + 1, y + 1);
            Console.Write(text);
        }
    }
}
