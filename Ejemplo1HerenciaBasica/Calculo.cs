using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ejemplo1HerenciaBasica
{
    public class Calculo
    {
        //Atributos
        private double numero1;
        private double numero2;

        //Métodos setter y getter
        public void setNumero1(double valor) {
            this.numero1 = valor;
        }

        public void setNumero2(double valor)
        {
            this.numero2 = valor;
        }

        public double getNumero1() {
            return this.numero1;
        }

        public double getNumero2()
        {
            return this.numero2;
        }
     }
}
