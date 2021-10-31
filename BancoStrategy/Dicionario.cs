using BancoStrategy.Tipos;
using System.Collections.Generic;

namespace BancoStrategy
{
    public static class Dicionario
    {
        public static Dictionary<EnumBanco, Banco> ObterDados()
        {
            return new Dictionary<EnumBanco, Banco>
            {
                { EnumBanco.CAIXA_ECONOMICA, new CaixaEconomica() },
                { EnumBanco.SANTANDER, new Santander() }
            };
        }
    }
}
