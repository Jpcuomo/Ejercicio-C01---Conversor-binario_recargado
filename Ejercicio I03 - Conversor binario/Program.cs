namespace Ejercicio_C01___Conversor_binario_recargado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Conversor de binarios/ decimales";

            int valorBinario = Validador.ValidadorBinarios();
            int numeroDecimal = Conversor.ConvertirBinarioADecimal(valorBinario);
            Console.WriteLine($"Decimal: {numeroDecimal}");

            Console.WriteLine("---------------------------");

            int valorDecimal = Validador.ValidadorEnteros();
            string numeroBinario = Conversor.ConvertirDecimalABinario(valorDecimal);
            Console.WriteLine($"Binario: {numeroBinario}");
        }   
    }
}