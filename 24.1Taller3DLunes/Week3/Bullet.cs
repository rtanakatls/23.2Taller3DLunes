using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D.Week3
{
    internal class Bullet : Projectile
    {
        public Bullet(int damage, float price)
        {
            this.damage = damage;
            this.price = price;
        }
    }
}
