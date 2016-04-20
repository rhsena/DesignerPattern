using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattern.Factory
{
    public abstract class EnemyShip
    {
        public string Name { get; set; }
        public double AmtDamage { get; set; }

        public void FollowHeroShip()
        {
            Console.WriteLine(Name + " is following the hero");
        }
        public void DisplayEnemyShip()
        {
            Console.WriteLine(Name + " is on the screen");
        }
        public void EnemyShipShoot()
        {
            Console.WriteLine(Name + " attacks and does " + AmtDamage);
        }
    }
}
