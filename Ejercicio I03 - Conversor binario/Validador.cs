using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_C01___Conversor_binario_recargado
{
    internal class Validador
    {
        /// <summary>
        /// Valida que el número ingresado sea un entero mayor o igual a cero
        /// </summary>
        /// <returns>Número entero >= 0</returns>
        internal static double ValidadorDecimal()
        {
            while (true)
            {
                Console.Write("Ingrese un número entero en base decimal: ");
                string numeroString = Console.ReadLine();   
                try
                {
                    double numeroEntero = double.Parse(numeroString);
                    if (numeroEntero >= 0 && numeroEntero <= double.MaxValue)
                    {
                        return numeroEntero;
                    }
                    else
                    {
                        Console.WriteLine($"Debes ingresar un número entero entre 0 y {double.MaxValue}");
                    }
                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("El formato no es correcto para un número entero");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Debes ingresar un número entero entre 0 y {double.MaxValue}");
                }
            }
        }


        /// <summary>
        /// Valida que el número ingresado contenga solo números binarios
        /// </summary>
        /// <returns>Número entero con dígitos binarios</returns>
        internal static string ValidadorBinarios()
        {
            while (true)
            {
                Console.Write("Ingrese un número en base binaria: ");
                string binarioString = Console.ReadLine();
                bool flagDigitoBinario = true;

                if (!string.IsNullOrEmpty(binarioString))
                {
                    for (int i = binarioString.Length - 1; i >= 0; i--)
                    {
                        char digito = binarioString[i];
                        if (digito != '0' && digito != '1')
                        {
                            flagDigitoBinario = false;
                            Console.WriteLine("Solo puedes ingresar dígitos binarios");
                            break;
                        }
                    }
                }
                else
                {
                    flagDigitoBinario = false;
                    Console.WriteLine("El campo no puede estar vacío. Ingresa un número en formato binario");
                }

                if (flagDigitoBinario)
                {
                    return binarioString;
                }
            }
        }
    }
}