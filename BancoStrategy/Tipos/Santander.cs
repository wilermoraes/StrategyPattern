using System;
using System.Collections.Generic;
using System.Text;

namespace BancoStrategy.Tipos
{
    public class Santander : Banco
    {
        public override void ObterNomeBanco()
        {
            Console.WriteLine("Esse banco é o Santander");
        }
    }
}
