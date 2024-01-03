using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01___Conversor_binario_recargado
{
    internal class NumeroBinario
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
            return new string(nb.ToString());
        }



        public static string operator +(NumeroBinario nb, NumeroDecimal nd)
        {

            return nb.Numero + Conversor.ConvertirDecimalABinario((int)nd.Numero);
        }
    }
}
