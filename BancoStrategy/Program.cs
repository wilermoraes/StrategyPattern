using BancoStrategy.Extensoes;
using BancoStrategy.VM;
using System;
using System.Linq;

namespace BancoStrategy
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simulação da informação de uma ViewModel
            BancoVM bancoVM = new BancoVM(100, "SANTANDER");

            if (!Enum.TryParse(bancoVM.Banco, true, out EnumBanco elemento))
            {
                Console.WriteLine("Banco não identificado");
                return;
            }

            StrategyComEnum(bancoVM, elemento);
            StrategyComDictionary(bancoVM, elemento);

            Console.ReadKey();
        }

        private static void StrategyComEnum(BancoVM bancoVM, EnumBanco elemento)
        {
            Console.WriteLine("=== Strategy com Enum e Extension Method ===");

            Banco banco = elemento.ObterBanco();
            banco.ObterNomeBanco();
        }


        private static void StrategyComDictionary(BancoVM bancoVM, EnumBanco elemento)
        {
            Console.WriteLine("\n=== Strategy com Enum e Dictionary ===");

            var dicionario = Dicionario.ObterDados()
                .Where(x => x.Key == elemento)
                .Select(x => x.Value)
                .FirstOrDefault();

            if (dicionario == null)
            {
                Console.WriteLine("Banco não identificado no dicionário");
                return;
            }

            dicionario.Invoke().ObterNomeBanco();
        }
    }
}
