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


        // Conversor implicito de NumeroBinario a string
        public static implicit operator string(NumeroBinario nb)
        {
            return nb.Numero;
        }


        // Sobrecarga de operador + y - entre NumeroBinario y NumeroDecimal
        public static string operator +(NumeroBinario nb, NumeroDecimal nd)
        {
            int numDecimal = Conversor.ConvertirBinarioADecimal(nb.Numero) + (int)nd.Numero;
            return Conversor.ConvertirDecimalABinario(numDecimal);
        }
        public static string operator -(NumeroBinario nb, NumeroDecimal nd)
        {
            int numDecimal = Math.Abs(Conversor.ConvertirBinarioADecimal(nb.Numero) - (int)nd.Numero);
            return Conversor.ConvertirDecimalABinario(numDecimal);
        }


        // Sobrecarga de operador == y != entre NumeroBinario y NumeroDecimal
        public static bool operator ==(NumeroBinario nb, NumeroDecimal nd)
        {
            return nb.Numero == Conversor.ConvertirDecimalABinario((int)nd.Numero);
        }
        public static bool operator !=(NumeroBinario nb, NumeroDecimal nd)
        {
            return !(nb == nd);
        }
    }
}
