using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D.Week3
{
    internal class Projectile : Item
    {
        protected int damage;

        public int Damage
        {
            get
            {
                return damage;
            }
        }
    }
}
