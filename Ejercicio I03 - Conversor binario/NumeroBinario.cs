using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01___Conversor_binario_recargado
{
    public class NumeroBinario
    {
        private string _numero;

        private NumeroBinario(string numero)
        {
            _numero = numero;
        }

        public string Numero
        {
            get {return _numero; }
        }


        //public override string ToString()
        //{
        //    return Numero;
        //}


        // Conversor implicito de string a NumeroBinario
        public static implicit operator NumeroBinario(string numBinario)
        {
            return new NumeroBinario(numBinario);
        }

        public static explicit operator string(NumeroBinario nb)
        {
            return nb.Numero.ToString();
        }

        public static explicit operator NumeroBinario(NumeroDecimal nd)
        {
            return new NumeroBinario(Conversor.DecimalABinario(nd.Numero));
        }


        // Sobrecarga de operador + y - entre NumeroBinario y NumeroDecimal
        public static string operator +(NumeroBinario nb, NumeroDecimal nd)
        {
            return Conversor.DecimalABinario(((NumeroDecimal)nb).Numero + nd.Numero);
        }
        public static string operator -(NumeroBinario nb, NumeroDecimal nd)
        {
            double numDecimal = ((NumeroDecimal)nb).Numero - nd.Numero;
            return Conversor.DecimalABinario(numDecimal);
        }


        // Sobrecarga de operador == y != entre NumeroBinario y NumeroDecimal
        public static bool operator ==(NumeroBinario nb, NumeroDecimal nd)
        {
            return nb.Numero == ((NumeroBinario)nd).Numero;
        }
        public static bool operator !=(NumeroBinario nb, NumeroDecimal nd)
        {
            return !(nb == nd);
        }
    }
}
