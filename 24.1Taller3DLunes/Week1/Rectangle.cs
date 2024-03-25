using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D
{
    internal class Rectangle : Shape
    {
        private float b;
        private float h;

        public Rectangle(string name, float b, float h)
        {
            this.b = b;
            this.h = h;
            this.name = name;
        }

        public override float GetArea()
        {
            return b * h;
        }

        public float GetPerimeter()
        {
            return 2 * (b + h);
        }
    }
}
