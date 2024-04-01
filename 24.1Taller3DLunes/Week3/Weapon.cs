using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D.Week3
{
    internal class Weapon : Item
    {
        protected string name;
        protected int damage;
        protected float attackSpeed;

        public virtual float GetDamagePerSecond()
        {
            return damage * attackSpeed;
        }

        public string GetData()
        {
            return $"El arma: {name} cuesta {price} y tiene {GetDamagePerSecond()} daño por segundo";
        }
    }
}
