using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo1HerenciaBasica
{
    public class Resta : Calculo
    {

        public double restar() {
            return (this.getNumero1() - this.getNumero2());
        }

    }
}
