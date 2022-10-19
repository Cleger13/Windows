using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Windows
{
    abstract class Interactable : View
    {
        public Interactable(int x, int y, int width, int height) : base(x, y, width, height){}

        public abstract void Interact();
    }
}
