using System;
using System.Collections.Generic;

namespace Cache
{
    class Program
    {
        static void Main(string[] args)
        {
            var cache = new Dictionary<string, int>();

            while (true)
            {
                Console.WriteLine("Digite a chave:");
                var chave = Console.ReadLine();
                Console.WriteLine("Digite o valor:");
                var valor = Int32.Parse(Console.ReadLine());
                cache.Add(chave, valor);
                Console.WriteLine("Qual é a chave?");
                string chaveBusca = Console.ReadLine();
                int valorBusca = cache.GetValueOrDefault(chaveBusca);
                Console.WriteLine(valorBusca);
                Console.WriteLine(value: "-----------------");
   

            }

        }
    }
}
