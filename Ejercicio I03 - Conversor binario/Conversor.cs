using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01___Conversor_binario_recargado
{
    public static class Conversor
    {
        /// <summary>
        /// Convierte a un número en base 10 a su equivalente en base 2
        /// </summary>
        /// <param name="numeroEntero"></param>
        /// <returns>String formado por dígitos binarios</returns>
        public static string DecimalABinario(double numeroEntero)
        {
            if (numeroEntero == 0)
            {
                return "0";
            }

            string binario = "";
            int parteEntera = Math.Abs((int)numeroEntero);
            int resto;

            while (parteEntera != 0)
            {
                resto = parteEntera % 2;
                parteEntera = parteEntera / 2;
                binario = resto.ToString() + binario;
            }

            if(numeroEntero < 0)
            {
                binario = "-" +  binario;
            }

            return binario;
        }


        /// <summary>
        /// Convierte a un número en base 2 a su equivalente en base 10
        /// </summary>
        /// <param name="numeroEntero"></param>
        /// <returns>Entero en base 10</returns>
        public static double BinarioADecimal(string numeroString)
        {
            double enteroConvertido = 0;
            double exponente = 0;
            double signo;

            if (numeroString[0] == '-')
            {
                numeroString = numeroString.Substring(1);
                signo = -1;
            }
            else
            {
                signo = 1;
            }

            for (int i = numeroString.Length - 1; i >= 0; i--)
            {
                char digitoChar = numeroString[i];
                double digito = double.Parse(digitoChar.ToString());
                enteroConvertido += digito * (double)Math.Pow(2, exponente);
                exponente++;
            }
            return enteroConvertido * signo;
        }
    }
}
