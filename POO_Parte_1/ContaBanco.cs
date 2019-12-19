using System;
namespace Modelo_Console_POO
{
    public class ContaBanco
    {
        private double _saldo { get; set; }
        public string NumeroDaConta { get; private set; }
        public string Agencia { get; private set; }
        public string Nome { get; private set; }
       
        

        public ContaBanco()
        {

        }

        public ContaBanco(string NumeroDaConta, string Nome)
        {
            this.NumeroDaConta = NumeroDaConta;
            this.Nome= Nome;
         
        }

        public void Deposito(double valor)
        {
            _saldo += valor;
        }

        public void Retirada(double valor)
        {
            _saldo -= valor;
        }



    }
}
