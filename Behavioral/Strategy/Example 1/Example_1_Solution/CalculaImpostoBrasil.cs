namespace Example_1_Solution
{
    public class CalculaImpostoBrasil : ICalculaImpostoPais
    {
        public decimal CalcularValorImposto(decimal totalRenda, decimal totalDeducao)
        {
            return (totalRenda - totalDeducao) * 20 / 100;
        }
    }
}
