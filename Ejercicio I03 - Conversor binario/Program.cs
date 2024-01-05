namespace Ejercicio_C01___Conversor_binario_recargado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Conversor de binarios/ decimales";

            //string valorBinario = Validador.ValidadorBinarios();
            //double numeroDecimal = Conversor.BinarioADouble(valorBinario);
            //Console.WriteLine($"Decimal: {numeroDecimal}");

            //Console.WriteLine("---------------------------");

            //double valorDecimal = Validador.ValidadorDecimal();
            //string numeroBinario = Conversor.DecimalABinario(valorDecimal);
            //Console.WriteLine($"Binario: {numeroBinario}");


            NumeroBinario num = Validador.ValidadorBinarios();
            Console.WriteLine(num.Numero);

            NumeroDecimal nd1 = Validador.ValidadorDecimal();
            Console.WriteLine(nd1.Numero);

            string numeroBinarioResultante = num - nd1;
            Console.WriteLine(numeroBinarioResultante);

            double numeroDecimalResultante = nd1 - num;
            Console.WriteLine(numeroDecimalResultante);

            bool sonIguales = nd1 == num;
            Console.WriteLine(sonIguales);

            NumeroBinario objBinario = "1001";
            NumeroDecimal objDecimal = 9;
            Console.WriteLine(objBinario.Numero);
            Console.WriteLine(objDecimal.Numero);

            string binario = (string)num;
            double numeroDecimal = (double)objDecimal;
            Console.WriteLine(binario.GetType());
            Console.WriteLine(numeroDecimal.GetType());

            // Comparación entre instancias del mismo tipo
            bool sonIgualesDecimal = nd1.Numero == ((NumeroDecimal)num).Numero;
            Console.WriteLine($"¿Son iguales (decimal)? {sonIgualesDecimal}");
        }
    }
}