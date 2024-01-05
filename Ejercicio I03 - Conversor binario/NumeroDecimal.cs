using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01___Conversor_binario_recargado
{
    public class NumeroDecimal
    {
        private double _numero;

        private NumeroDecimal(double numero)
        {
            _numero = numero;
        }

        public double Numero
        {
            get { return _numero; }
        }


        // Conversor implicito de NumeroDecimal a double
        public static implicit operator double(NumeroDecimal nd)
        {
            return nd.Numero;
        }


        // Sobrecarga de operador + y - entre NumeroBinario y NumeroDecimal
        public static double operator +(NumeroDecimal nd, NumeroBinario nb)
        {
            return nd.Numero + Conversor.ConvertirBinarioADecimal(nb.Numero);
        }
        public static double operator -(NumeroDecimal nd, NumeroBinario nb)
        {
            return Math.Abs(nd.Numero - Conversor.ConvertirBinarioADecimal(nb.Numero));
        }


        // Sobrecarga de operador == y != entre NumeroBinario y NumeroDecimal
        public static bool operator ==(NumeroDecimal nd, NumeroBinario nb)
        {
            return nd.Numero == Conversor.ConvertirBinarioADecimal(nb.Numero);
        }
        public static bool operator !=(NumeroDecimal nd, NumeroBinario nb)
        {
            return !(nd == nb);
        }
    }
}
