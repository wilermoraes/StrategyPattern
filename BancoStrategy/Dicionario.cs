using BancoStrategy.Tipos;
using System;
using System.Collections.Generic;

namespace BancoStrategy
{
    public static class Dicionario
    {
        public static Dictionary<EnumBanco, Func<Banco>> ObterDados()
        {
            return new Dictionary<EnumBanco, Func<Banco>>
            {
                { EnumBanco.CAIXA_ECONOMICA, () => new CaixaEconomica() },
                { EnumBanco.SANTANDER, () => new Santander() }
            };
        }
    }
}
