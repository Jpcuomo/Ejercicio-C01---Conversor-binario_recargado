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
        public static implicit operator NumeroDecimal(double numDecimal)
        {
            return new NumeroDecimal(numDecimal);
        }

        public static explicit operator double(NumeroDecimal nd)
        {
            return (double)nd.Numero;
        }

        public static explicit operator NumeroDecimal(NumeroBinario nb)
        {
            return new NumeroDecimal(Conversor.BinarioADecimal(nb.Numero));
        }


        // Sobrecarga de operador + y - entre NumeroBinario y NumeroDecimal
        public static double operator +(NumeroDecimal nd, NumeroBinario nb)
        {
            return nd.Numero + ((NumeroDecimal)nb).Numero;
        }
        public static double operator -(NumeroDecimal nd, NumeroBinario nb)
        {
            return nd.Numero - ((NumeroDecimal)nb).Numero;
        }


        // Sobrecarga de operador == y != entre NumeroBinario y NumeroDecimal
        public static bool operator ==(NumeroDecimal nd, NumeroBinario nb)
        {
            return nd.Numero == ((NumeroDecimal)nb).Numero;
        }
        public static bool operator !=(NumeroDecimal nd, NumeroBinario nb)
        {
            return !(nd == nb);
        }
    }
}
