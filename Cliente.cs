using System;
namespace Modelo_Console_POO
{
    public class Cliente
    {
        public string Nome;
        public string Telefone;
        public string DataAniversario;
        public string Email;


        //Precisa do construtor vazio para usar o this nos outros construtores
        public Cliente()
        {

        }

        //Construtor - Cadastro Simples - Sobrecarga
        public Cliente(string Nome, string Telefone)
        {
            this.Nome = Nome;
            this.Telefone = Telefone;

        }

        //Construtor - Cadastro Completo - Sobrecarga
        public Cliente(string Nome, string Telefone, string DataAniversario, string Email) : this(Nome, Telefone)
        {

            this.DataAniversario = DataAniversario;
            this.Email = Email;

        }

        public void ConferirDadosCliente()
        {
            Console.WriteLine("Nome: " + Nome + " Telefone: " + Telefone + " DataAniversario" + DataAniversario + " Email: " + Email);
        }


        public void CadastroSimples()
        {
            Console.Write("Nome do Cliente: ");
            this.Nome = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Telefone : ");
           this.Telefone = Console.ReadLine();
        }

        public void CadastroCompleto()
        {
            CadastroSimples();

            Console.Write("Data de Aniversario ");
            this.DataAniversario  = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Email : ");
            this.Email = Console.ReadLine();
        }


    }
}
