using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public static class Calculo
    {
        public static double Somar(double numero1, double numero2)
        {
            return (numero1 + numero2);
        }

        public static double Subtrair(double numero1, double numero2)
        {
            return (numero1 - numero2);
        }

        public static double Multiplicar(double numero1, double numero2)
        {
            return (numero1 * numero2);
        }

        public static double Dividir(double numero1, double numero2)
        {
            return (numero1 / numero2);
        }

    }
}
