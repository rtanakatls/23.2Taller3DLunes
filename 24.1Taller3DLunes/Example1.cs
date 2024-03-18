using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D
{
    internal class Example1
    {
        public void Execute()
        {
            bool continueFlag = true;

            while (continueFlag)
            {
                int a;
                int b;

                Console.WriteLine("Ingresar el primer número");
                a = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingresar el segundo número");
                b = int.Parse(Console.ReadLine());

                Console.WriteLine($"La suma de los números es: {a + b}");

                bool validOption = false;
                while (!validOption)
                {
                    Console.WriteLine("Elige una opción");
                    Console.WriteLine("1. Volver a introducir números");
                    Console.WriteLine("2. Salir");
                    string option = Console.ReadLine();
                    switch (option)
                    {
                        case "1":
                            validOption = true;
                            break;
                        case "2":
                            continueFlag = false;
                            validOption = true;
                            break;
                        default:
                            Console.WriteLine("Opción inválida");
                            break;
                    }

                }
            }
        }

    }
}
