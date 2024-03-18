using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D
{
    internal class Exercise1
    {
        public void Rectangle()
        {
            int a;
            int b;
            Console.WriteLine("Introducir la base del rectángulo");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introducir la altura del rectángulo");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine($"El área del rectángulo es: {a * b}");
            Console.WriteLine($"El perímetro del rectángulo es: {2 * (a + b)}");
        }

        public void Triangle()
        {
            int a;
            int b;
            Console.WriteLine("Introducir la base del triángulo");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Introducir la altura del triángulo");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("El área del triángulo es: " + (a * b) / 2);
        }
    }
}
