using System;
using System.Collections;

namespace Pilha
{
    class Program
    {
        static void Main(string[] args)
        {

            Stack primeiraPilha = new Stack();
            int valor = 0;


            while (valor != -1 )
            {
                Console.WriteLine("Digite um item para a pilha:");
                valor = Int32.Parse(Console.ReadLine());
                primeiraPilha.Push(valor);
            }


            foreach (int i in primeiraPilha)
            {
                Console.WriteLine(i); 
            }


        }
    }
}
