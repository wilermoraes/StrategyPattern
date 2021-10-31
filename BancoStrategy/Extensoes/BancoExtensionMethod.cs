using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BancoStrategy.Extensoes
{
    public static class BancoExtensionMethod
    {
        public static Banco ObterBanco(this EnumBanco banco)
        {
            var atributo = typeof(EnumBanco).GetFields()
                .Where(f => f.Name == banco.ToString())
                .FirstOrDefault()?.GetCustomAttributes(false).First() as BancoAttribute;

            if (atributo == null)
                throw new NotImplementedException();

            return atributo.CreateInstance;
        }
    }
}
