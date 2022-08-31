namespace Example_1_Solution
{
    public class CalculaImpostoUSA : ICalculaImpostoPais
    {
        public decimal CalcularValorImposto(decimal totalRenda, decimal totalDeducao)
        {
            return (totalRenda - totalDeducao) * 30 / 100;
        }
    }
}
