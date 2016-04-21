using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattern.Factory
{
    public class BigUFOEnemyShip : EnemyShip
    {
        public BigUFOEnemyShip()
        {
            Name = "BIG UFO Enemy Ship";
            AmtDamage = 40.0;
        }
    }
}
