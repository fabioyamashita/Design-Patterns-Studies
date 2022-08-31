using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example_1_Solution
{
    public interface ICalculaImpostoPais
    {
        decimal CalcularValorImposto(decimal totalRenda, decimal totalDeducao);
    }
}
