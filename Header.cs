using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows
{
    class Header
    {
        public bool collapseButton;
        public bool expandButton;
        public bool closeButton;

        public string title;

        public Header(string title = "Title", bool expand = true, bool collapse = true, bool close = true)
        {
            this.title = title;
            collapseButton = collapse;
            expandButton = expand;
            closeButton = close;
        }

        public void Draw()
        {
            Console.Write(" " + title + " " + (collapseButton ? " _ " : "") + (expandButton ? " # " : "") + (closeButton ? " X " : ""));
        }
    }
}
