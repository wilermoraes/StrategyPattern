using System;

namespace BancoStrategy.VM
{
    public class BancoVM
    {
        public Guid Id { get; set; }
        public double Valor { get; private set; }
        public string Banco { get; private set; }

        public BancoVM(double valor, string banco)
        {
            Id = Guid.NewGuid();
            Valor = valor;
            Banco = banco;
        }
    }
}
