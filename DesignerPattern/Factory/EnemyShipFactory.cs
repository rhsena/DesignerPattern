using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattern.Factory
{
    public class EnemyShipFactory
    {
        public EnemyShip MakeEnemyShip(int newShipType)
        {
            EnemyShip newShip = null;
            switch (newShipType)
            {
                case 1:
                    newShip = new RocketEnemyShip();
                    break;
                case 2:
                    newShip = new UFOEnemyShip();
                    break;
                default:
                    newShip = new BigUFOEnemyShip();
                    break;
            }


            return newShip;
        }
    }
}
