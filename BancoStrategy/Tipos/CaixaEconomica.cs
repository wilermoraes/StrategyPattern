using System;
using System.Collections.Generic;
using System.Text;

namespace BancoStrategy.Tipos
{
    public class CaixaEconomica : Banco
    {
        public override void ObterNomeBanco()
        {
            Console.WriteLine("Esse banco é a Caixa Econômica Federal");
        }
    }
}
