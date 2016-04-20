using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattern.Factory
{
    public class UFOEnemyShip : EnemyShip
    {
        public UFOEnemyShip()
        {
            Name = "UFO Enemy Ship";
            AmtDamage = 20.0;
        }
    }
}
