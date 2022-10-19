using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows
{
    abstract class View
    {
        public int x;
        public int y;
        public int width;
        public int height;
        public int xLimit;
        public int yLimit;

        public View(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public void SetmoveLimints(int x, int y)
        {
            xLimit = x;
            yLimit = y;
        }

        public abstract void Draw();

        protected void DrawBorders()
        {
            Drawer.DrawVerticalLine(x, y, height);
            Drawer.DrawVerticalLine(x + width, y, height);
            Drawer.DrawHorizontalLine(x, y, width);
            Drawer.DrawHorizontalLine(x, y + height, width);

            Drawer.DrawAtPosition(x, y, '╔');
            Drawer.DrawAtPosition(x + width, y, '╗');
            Drawer.DrawAtPosition(x, y + height, '╚');
            Drawer.DrawAtPosition(x + width, y + height, '╝');
        }

        public virtual bool Move(int xMove, int yMove)
        {
            if (x + xMove < 0 || y + yMove < 0 || x + xMove + width + 1 > Console.BufferWidth || y + yMove + height + 1 > Console.BufferHeight)
            {
                return false;
            }

            x += xMove;
            y += yMove;

            return true;
        }
    }
}
