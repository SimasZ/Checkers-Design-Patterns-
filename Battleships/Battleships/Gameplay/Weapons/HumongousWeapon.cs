using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Battleships.Gameplay.Weapons
{
    public class HumongousWeapon : Weapon
    {
        protected override void Fire()
        {
            Console.WriteLine("HumongousWeapon");
        }
    }
}
