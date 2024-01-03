using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01___Conversor_binario_recargado
{
    internal class NumeroDecimal
    {
        private double _numero;

        private NumeroDecimal(double numero)
        {
            _numero = numero;
        }

        public double Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }


        // Conversor implicito de NumeroDecimal a double
        public static implicit operator double(NumeroDecimal nd)
        {
            return (double)nd.Numero;
        }

        public static explicit operator int(NumeroDecimal nb)
        {
            return (int)nb.Numero;
        }
    }
}
