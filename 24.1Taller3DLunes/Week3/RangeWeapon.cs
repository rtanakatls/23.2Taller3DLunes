using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taller3D.Week3
{
    internal class RangeWeapon : Weapon
    {
        protected Projectile projectile;

        public override float GetDamagePerSecond()
        {
            return (damage + projectile.Damage) * attackSpeed;
        }
    }
}
