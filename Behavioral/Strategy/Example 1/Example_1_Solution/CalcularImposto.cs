namespace Example_1_Solution
{
    class CalcularImposto
    {
        private ICalculaImpostoPais _calculaImpostoPais;

        public CalcularImposto() { }

        public CalcularImposto(ICalculaImpostoPais calculaImpostoPais) 
        {
            _calculaImpostoPais = calculaImpostoPais;
        }
 
        public void setCalculoImpostoPais(ICalculaImpostoPais calculaImpostoPais)
        {
            _calculaImpostoPais = calculaImpostoPais;
        }

        public decimal Calcular(decimal totalRenda, decimal totalDeducao)
        {
            return _calculaImpostoPais.CalcularValorImposto(totalRenda, totalDeducao);
        }
    }
}
