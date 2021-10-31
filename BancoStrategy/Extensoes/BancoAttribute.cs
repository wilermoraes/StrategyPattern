using System;
using System.Collections.Generic;
using System.Text;

namespace BancoStrategy.Extensoes
{
    public class BancoAttribute : Attribute
    {
        private Type _implementation { get; }

        public Banco CreateInstance => (Banco)Activator.CreateInstance(_implementation);

        public BancoAttribute(Type implementation)
        {
            _implementation = implementation;
        }
    }
}
