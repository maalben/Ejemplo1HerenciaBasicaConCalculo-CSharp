using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo1HerenciaBasica
{
    public class Division : Calculo
    {

        public double dividir() {
            return (this.getNumero1() / this.getNumero2());
        }

    }
}
