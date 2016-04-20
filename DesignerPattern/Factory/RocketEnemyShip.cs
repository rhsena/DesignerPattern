using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattern.Factory
{
    public class RocketEnemyShip : EnemyShip
    {
        public RocketEnemyShip()
        {
            Name = "Rocket Enemy Ship";
            AmtDamage = 10.0;
        }
    }
}
