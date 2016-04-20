using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignerPattern.Strategy
{
    public class Animal
    {
        public Voar tipoVoador;

        public string TentarVoar()
        {
            return tipoVoador.fly();
        }

        public void setHabilidadeVoar(Voar newTipoVoador)
        {
            this.tipoVoador = newTipoVoador;
        }
    }
}
