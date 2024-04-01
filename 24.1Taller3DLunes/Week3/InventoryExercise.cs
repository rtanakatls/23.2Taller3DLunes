using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D.Week3
{
    internal class InventoryExercise
    {
        private List<Weapon> weapons;

        public InventoryExercise()
        {
            weapons = new List<Weapon>();
        }

        public void Execute()
        {
            MainMenu();
        }

        private void MainMenu()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce el número de la opción:");
                Console.WriteLine("1. Agregar arma");
                Console.WriteLine("2. Mostrar armas");
                Console.WriteLine("3. Eliminar arma");
                Console.WriteLine("4. Salir");
                string option = Console.ReadLine();
                switch(option)
                {
                    case "1":
                        AddWeapon();
                        break;
                    case "2":
                        ShowWeapons();
                        break;
                    case "3":
                        RemoveWeapon();
                        break;
                    case "4":
                        continueFlag = false;
                        break;
                }

            }
        }

        private void AddWeapon()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introduce el número del arma que quieres añadir: ");
                Console.WriteLine("1. Espada");
                Console.WriteLine("2. Arco");
                Console.WriteLine("3. Pistola");
                Console.WriteLine("4. Regresar al menú anterior");
                string option = Console.ReadLine();
                switch (option)
                {
                    case "1":
                        AddSword();
                        continueFlag = false;
                        break;
                    case "2":
                        AddBow();
                        continueFlag = false;
                        break;
                    case "3":
                        AddPistol();
                        continueFlag = false;
                        break;
                    case "4":
                        continueFlag = false;
                        break;
                    default:
                        Console.WriteLine("Opción no válida");
                        break;
                }
            }
        }

        private void AddSword()
        {
            Console.WriteLine("Introducir nombre de la espada");
            string name = Console.ReadLine();
            Console.WriteLine("Introducir daño de la espada");
            int damage = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la velocidad de ataque de la espada");
            float attackSpeed = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el precio de la espada");
            float price = float.Parse(Console.ReadLine());
            weapons.Add(new Sword(name, damage, attackSpeed, price));
        }
        private void AddBow()
        {
            Console.WriteLine("Introducir nombre del arco");
            string name = Console.ReadLine();
            Console.WriteLine("Introducir daño del arco");
            int damage = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la velocidad del arco");
            float attackSpeed = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el precio del arco");
            float price = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el daño de la flecha");
            int arrowDamage = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el precio de la flecha");
            int arrowPrice = int.Parse(Console.ReadLine());
            weapons.Add(new Bow(name, damage, attackSpeed, price, new Arrow(arrowDamage, arrowPrice)));
        }
        private void AddPistol()
        {
            Console.WriteLine("Introducir nombre de la pistola");
            string name = Console.ReadLine();
            Console.WriteLine("Introducir daño de la pistola");
            int damage = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce la velocidad de la pistola");
            float attackSpeed = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el precio de la pistola");
            float price = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el daño de la bala");
            int bulletDamage = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el precio de la bala");
            int bulletPrice = int.Parse(Console.ReadLine());
            weapons.Add(new Pistol(name, damage, attackSpeed, price, new Bullet(bulletDamage, bulletPrice)));
        }

        private void ShowWeapons()
        {
            foreach(Weapon weapon in weapons)
            {
                Console.WriteLine(weapon.GetData());
            }
        }

        private void RemoveWeapon()
        {
            bool continueFlag = true;
            while (continueFlag)
            {
                Console.WriteLine("Introducir el número del arma a eliminar");
                for (int i = 0; i < weapons.Count; i++)
                {
                    Console.WriteLine($"{i}. {weapons[i].GetData()}");
                }
                int index = int.Parse(Console.ReadLine());
                if (index >= 0 && index < weapons.Count)
                {
                    continueFlag = false;
                    weapons.RemoveAt(index);
                }
                else
                {
                    Console.WriteLine("El arma no existe");
                }
            }

        }
    }
}
