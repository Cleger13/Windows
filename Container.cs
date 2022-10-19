using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows
{
    class Container : View
    {
        private List<View> elements = new List<View>();

        public Container(int x, int y, int width, int height) : base(x, y, width, height){}
        
        public virtual void Pack(View element, bool moveToParentPosition = true)
        {
            elements.Add(element);
            if (moveToParentPosition)
            {
                element.Move(x, y);
            }
        }

        public void Pack(params View[] elements)
        {
            foreach (View element in elements)
            {
                Pack(element);
            }
        }

        public override void Draw()
        {
            DrawBorders();

            foreach (View elem in elements)
            {
                elem.Draw();
            }
        }

        public override bool Move(int xMove, int yMove)
        {
            bool moved = base.Move(xMove, yMove);

            if (!moved) return false;

            foreach (View elem in elements)
            {
                elem.Move(xMove, yMove);
            }

            return true;
        }
    }
}
