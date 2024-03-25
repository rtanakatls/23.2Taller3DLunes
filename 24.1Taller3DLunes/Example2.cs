using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D
{
    internal class Example2
    {
        public void Execute()
        {
            Shape[] shapeArray=new Shape[2];
            shapeArray[0] = new Rectangle("Rectángulo", 5, 10);
            shapeArray[1] = new Triangle("Triángulo", 5, 10);

            for (int i = 0; i < shapeArray.Length; i++)
            {
                Console.WriteLine($"El área del {shapeArray[i].Name} es {shapeArray[i].GetArea()}");
            }

        }

    }
}
