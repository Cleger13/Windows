using Windows;

class Program
{
    static void Main(string[] args)
    {
        Console.CursorVisible = false;

        Window helloWindow = new Window(3, 2, 40, 20, new Header("Input Fields"));
        Label label1 = new Label("Hello world!", 2, 2, 25, 2);
        Label b1Clicks = new Label("Кнопка 1 нажата 0 раз", 3, 13, 30, 2);
        int b1Count = 0;
        Button button1 = new Button("Кнопка 1", () => b1Clicks.SetText($"Кнопка 1 нажата {++b1Count} раз"), 2, 17, 10, 2);
        helloWindow.Pack(label1, b1Clicks, button1);

        Window secWindow = new Window(45, 2, 40, 20, new Header("Second Window"));
        Label b2Clicks = new Label("Кнопка 2 нажата 0 раз", 6, 9, 30, 2);
        Label b3Clicks = new Label("Кнопка 3 нажата 0 раз", 6, 13, 30, 2);
        int b2Count = 0;
        int b3Count = 0;
        Button button2 = new Button("Кнопка 2", () => b2Clicks.SetText($"Кнопка 2 нажата {++b2Count} раз"), 5, 17, 10, 2);
        Button button3 = new Button("Кнопка 3", () => b3Clicks.SetText($"Кнопка 3 нажата {++b3Count} раз"), 20, 17, 10, 2);
        secWindow.Pack(b2Clicks, button2, b3Clicks, button3);

        while (true)
        {
            WinController.DrawWindows();
            WinController.ListenKeys();
        }
    }
}