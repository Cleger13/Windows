using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows
{
    static class WinController
    {
        private static List<Window> windows = new List<Window>();
        private static int activeWindowIndex = 0;

        private static Window? ActiveWindow
        {
            get { return windows.Count > 0 ? windows[activeWindowIndex] : null; }
        }
        
        public static void AddWindow(Window window)
        {
            ActiveWindow?.SetActive(false);
            window.SetActive(true);
            windows.Add(window);
            SwitchWindow();
        }

        public static void DrawWindows()
        {
            Console.Clear();
            foreach (Window window in windows)
            {
                if (window != ActiveWindow)
                {
                    window.Draw();
                }
            }
            ActiveWindow?.Draw();
        }

        public static void ListenKeys()
        {
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.Tab:
                    if (key.Modifiers == ConsoleModifiers.Shift)
                    {
                        SwitchWindow();
                    }
                    else
                    {
                        ActiveWindow?.SwitchInteractable();
                    }
                    break;

                case ConsoleKey.UpArrow:
                    ActiveWindow?.Move(0, -1);
                    break;

                case ConsoleKey.DownArrow:
                    ActiveWindow?.Move(0, 1);
                    break;

                case ConsoleKey.LeftArrow:
                    ActiveWindow?.Move(-1, 0);
                    break;

                case ConsoleKey.RightArrow:
                    ActiveWindow?.Move(1, 0);
                    break;

                case ConsoleKey.Enter:
                    ActiveWindow?.Interact();
                    break;

                case ConsoleKey.Escape:
                    Environment.Exit(0);
                    break;
            }
        }

        public static void SwitchWindow()
        {
            ActiveWindow?.SetActive(false);
            if (++activeWindowIndex >= windows.Count)
            {
                activeWindowIndex = 0;
            }
            ActiveWindow?.SetActive(true);
        }
    }
}
