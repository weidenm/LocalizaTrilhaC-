using System;

namespace EntendendoOO
{
	public class Conta
    {
        private int _agencia;
        private int _numero;
        private int _saldo;

        public int Saldo
        {
            get { return _saldo;  }
        }

        public Conta(int agencia, int numero)
        {
            _agencia = agencia;
            _numero = numero;
            _saldo = Saldo;

        }


		public Conta():this(nome: "Cristiano")
        {
			EhVip = true;
        }


        public Conta(string nome)
        {
            _nome = nome;
        }
    }



}

public class Class1
{
	public Class1()
	{
	}
}
