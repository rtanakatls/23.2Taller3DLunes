using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D
{
    internal class Circle : Shape
    {
        private float radius;

        public Circle(string name, float radius)
        {
            this.radius = radius;
            this.name = name;
        }

        public override float GetArea()
        {
            return 3.14f * radius * radius;
        }

    }
}
