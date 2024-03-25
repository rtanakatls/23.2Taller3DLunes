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
            bool continueFlag = true;

            while(continueFlag)
            {
                Shape shape = null;
                Console.WriteLine("Introduce el número de la figura que deseas crear");
                Console.WriteLine("1. Círculo");
                Console.WriteLine("2. Rectángulo");
                Console.WriteLine("3. Triángulo");
                Console.WriteLine("4. Salir");
                string option= Console.ReadLine();
                switch(option)
                {
                    case "1":
                        shape = GetCircle();
                        break;
                    case "2":
                        shape = GetRectangle();
                        break;
                    case "3":
                        shape = GetTriangle();
                        break;
                    case "4":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }

                if (shape != null)
                {
                    Console.WriteLine($"El área de {shape.Name} es {shape.GetArea()}");
                }
            }
        }

        private Circle GetCircle()
        {
            Console.WriteLine("Introduce el radio del círculo");
            float radius = float.Parse(Console.ReadLine());
            return new Circle("Círculo",radius);
        }

        private Rectangle GetRectangle()
        {
            Console.WriteLine("Introduce la base del rectángulo");
            float width= float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura del rectángulo");
            float height = float.Parse(Console.ReadLine());
            return new Rectangle("Rectángulo",width,height);
        }
        private Triangle GetTriangle()
        {
            Console.WriteLine("Introduce la base del triángulo");
            float width = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la altura del triángulo");
            float height = float.Parse(Console.ReadLine());
            return new Triangle("Triángulo", width, height);

        }

    }
}
