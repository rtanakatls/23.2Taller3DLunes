using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D
{
    internal class Triangle
    {
        private float b;
        private float h;

        public Triangle(float b, float h)
        {
            this.b = b;
            this.h = h;
        }

        public float GetArea()
        {
            return (b * h) / 2;
        }
    }
}
