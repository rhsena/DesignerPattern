using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattern.Strategy
{
    public class NaoVoa : Voar
    {
        public string fly()
        {
            return "Não Voo";
        }
    }
}
