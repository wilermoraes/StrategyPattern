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

            StrategyComEnum(bancoVM);
            StrategyComDictionary(bancoVM);

            Console.ReadKey();
        }

        private static void StrategyComEnum(BancoVM bancoVM)
        {
            Console.WriteLine("=== Strategy com Enum e Extension Method ===");

            if (!Enum.TryParse(bancoVM.Banco, true, out EnumBanco elementoEnum))
            {
                Console.WriteLine("Banco não identificado");
                return;
            }

            Banco banco = elementoEnum.ObterBanco();
            banco.ObterNomeBanco();
        }


        private static void StrategyComDictionary(BancoVM bancoVM)
        {
            Console.WriteLine("\n=== Strategy com Enum e Dictionary ===");

            if (!Enum.TryParse(bancoVM.Banco, true, out EnumBanco elementoEnum))
            {
                Console.WriteLine("Banco não identificado");
                return;
            }

            var dicionario = Dicionario.ObterDados()
                .Where(x => x.Key == elementoEnum)
                .Select(x => x.Value)
                .FirstOrDefault();

            if (dicionario == null)
            {
                Console.WriteLine("Banco não identificado no dicionário");
                return;
            }

            dicionario.ObterNomeBanco();
        }
    }
}
