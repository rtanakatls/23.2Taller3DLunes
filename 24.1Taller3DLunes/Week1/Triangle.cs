using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D
{
    internal class Triangle : Shape
    {
        private float b;
        private float h;

        public Triangle(string name, float b, float h)
        {
            this.b = b;
            this.h = h;
            this.name = name;
        }

        public override float GetArea()
        {
            return (b * h) / 2;
        }
    }
}
