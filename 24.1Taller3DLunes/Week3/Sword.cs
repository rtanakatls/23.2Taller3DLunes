using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D.Week3
{
    internal class Sword : MeleeWeapon
    {
        public Sword(string name, int damage, float attackSpeed, float price)
        {
            this.name = name;
            this.damage = damage;
            this.attackSpeed = attackSpeed;
            this.price = price;
        }
    }
}
