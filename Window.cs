using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows
{
    class Window : Container
    {
        public Header header = new Header();
        private bool active = false;

        private List<Interactable> interactables = new List<Interactable>();
        private int activeButtonIndex = 0;

        private Interactable? ActiveInteractable
        {
            get { return interactables.Count > 0 ? interactables[activeButtonIndex] : null; }
        }

        public Window(int x, int y, int width, int height, Header header) : base(x, y, width, height)
        {
            this.header = header;
            WinController.AddWindow(this);
        }

        public void SetActive(bool active)
        {
            this.active = active;
        }

        public override void Pack(View element, bool moveToParentPosition = true)
        {
            base.Pack(element, moveToParentPosition);
            if (element is Interactable)
            {
                interactables.Add((Interactable)element);
            }
        }

        public override void Draw()
        {
            if (!active)
            {
                Console.ForegroundColor = ConsoleColor.DarkGray;
            }

            base.Draw();
            Console.SetCursorPosition(x + 2, y);
            header.Draw();

            if (ActiveInteractable != null && active)
            {
                Console.SetCursorPosition(ActiveInteractable.x, ActiveInteractable.y + 1);
                Console.ForegroundColor = ConsoleColor.Green;

                ActiveInteractable.Draw();
            }

            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Interact()
        {
            ActiveInteractable?.Interact();
        }

        public void SwitchInteractable()
        {
            if (++activeButtonIndex >= interactables.Count)
            {
                activeButtonIndex = 0;
            }
        }
    }
}
