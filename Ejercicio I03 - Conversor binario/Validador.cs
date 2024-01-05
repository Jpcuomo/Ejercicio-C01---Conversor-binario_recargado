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
        internal static int ValidadorEnteros()
        {
            while (true)
            {
                Console.Write("Ingrese un número entero en base decimal: ");
                string numeroString = Console.ReadLine();   
                try
                {
                    int numeroEntero = int.Parse(numeroString);
                    if (numeroEntero >= 0 && numeroEntero <= int.MaxValue)
                    {
                        return numeroEntero;
                    }
                    else
                    {
                        Console.WriteLine($"Debes ingresar un número entero entre 0 y {int.MaxValue}");
                    }
                }
                catch(FormatException e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine("El formato no es correcto para un número entero");
                }
                catch (OverflowException)
                {
                    Console.WriteLine($"Debes ingresar un número entero entre 0 y {int.MaxValue}");
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

                if (flagDigitoBinario)
                {
                    return binarioString;
                }
                //    try
                //    {
                //        int valorDecimal = int.Parse(binarioString);
                //        return valorDecimal;
                //    }
                //    catch (FormatException)
                //    {
                //        Console.WriteLine("Solo puedes ingresar dígitos binarios");
                //    }
                //    catch(OverflowException)
                //    {
                //        Console.WriteLine("El número ingresado es demasiado grande");
                //    }
                //}
            }
        }
    }
}
