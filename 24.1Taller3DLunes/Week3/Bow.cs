using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D.Week3
{
    internal class Bow : RangeWeapon
    {
        public Bow(string name, int damage, float attackSpeed, float price, Arrow arrow)
        {
            this.name = name;
            this.damage = damage;
            this.attackSpeed = attackSpeed;
            this.price = price;
            this.projectile = arrow;
        }
    }
}
