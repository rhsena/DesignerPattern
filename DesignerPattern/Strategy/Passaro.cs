using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattern.Strategy
{
    public class Passaro : Animal
    {
        public Passaro()
        {
            tipoVoador = new Voa();
        }
    }
}
