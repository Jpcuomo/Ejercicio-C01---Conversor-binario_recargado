using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01___Conversor_binario_recargado
{
    internal class Conversor
    {
        /// <summary>
        /// Convierte a un número en base 10 a su equivalente en base 2
        /// </summary>
        /// <param name="numeroEntero"></param>
        /// <returns>String formado por dígitos binarios</returns>
        internal static string ConvertirDecimalABinario(int numeroEntero)
        {
            string binario = "";
            int resto;
            do
            {
                int cociente = numeroEntero / 2;
                resto = numeroEntero % 2;
                numeroEntero = cociente;
                binario = resto.ToString() + binario;

            } while (numeroEntero > 0);

            return binario;
        }


        /// <summary>
        /// Convierte a un número en base 2 a su equivalente en base 10
        /// </summary>
        /// <param name="numeroEntero"></param>
        /// <returns>Entero en base 10</returns>
        internal static int ConvertirBinarioADecimal(int numeroEntero)
        {
            string numeroString = numeroEntero.ToString();
            int enteroConvertido = 0;
            int exponente = 0;

            for (int i = numeroString.Length - 1; i >= 0; i--)
            {
                char digitoChar = numeroString[i];
                int digito = int.Parse(digitoChar.ToString());
                enteroConvertido += digito * (int)Math.Pow(2, exponente);
                exponente++;
            }
            return enteroConvertido;
        }
    }
}
