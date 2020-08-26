using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo1HerenciaBasica
{
    public class Suma : Calculo 
    {
        public double sumar() {
            return (this.getNumero1() + this.getNumero2());
        }

    }
}
