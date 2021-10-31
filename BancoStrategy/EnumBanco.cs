using BancoStrategy.Extensoes;
using BancoStrategy.Tipos;

namespace BancoStrategy
{
    public enum EnumBanco
    {
        [BancoAttribute(typeof(CaixaEconomica))]
        CAIXA_ECONOMICA,

        [BancoAttribute(typeof(Santander))]
        SANTANDER
    }
}
