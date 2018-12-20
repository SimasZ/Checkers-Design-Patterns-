using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Console = System.Console;

namespace Battleships.Gameplay.Weapons
{
    public class SmallWeapon : Weapon
    {
        protected override void Fire()
        {
            Console.WriteLine("SmallWeapon");
        }
    }
}
