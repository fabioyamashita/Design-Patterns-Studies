using System;
using System.Globalization;

namespace Example_1_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            var impostoNoPais = new CalcularImposto();

            var totalRenda = 1000.0M;
            var totalDeducao = 100.0M;
            var totalImposto = 0.0M;

            Console.WriteLine("\nCalculando o imposto do Brasil");
            impostoNoPais.setCalculoImpostoPais(new CalculaImpostoBrasil());
            totalImposto = impostoNoPais.Calcular(totalRenda, totalDeducao);
            Console.WriteLine($"Brasil: {totalImposto.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("\nCalculando o imposto da Argentina");
            impostoNoPais.setCalculoImpostoPais(new CalculaImpostoArgentina());
            totalImposto = impostoNoPais.Calcular(totalRenda, totalDeducao);
            Console.WriteLine($"Argentina: {totalImposto.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("\nCalculando o imposto do USA");
            impostoNoPais.setCalculoImpostoPais(new CalculaImpostoUSA());
            totalImposto = impostoNoPais.Calcular(totalRenda, totalDeducao);
            Console.WriteLine($"USA: {totalImposto.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
