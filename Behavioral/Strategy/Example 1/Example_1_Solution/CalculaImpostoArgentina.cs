namespace Example_1_Solution
{
    public class CalculaImpostoArgentina : ICalculaImpostoPais
    {
        public decimal CalcularValorImposto(decimal totalRenda, decimal totalDeducao)
        {
            return (totalRenda - totalDeducao) * 50 / 100;
        }
    }
}
