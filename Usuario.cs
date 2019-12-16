using System;
namespace Modelo_Console_POO
{
    public class Usuario
    {
        public string login;
        public string senha;


        public Usuario()
        {

            Console.WriteLine("Digite o login:");
            login = Console.ReadLine();
           

            Console.WriteLine("Digite a senha:");
            senha = Console.ReadLine();


        }

        public void ConfereSenha()
        {
            string senha_correta = "2323BB";
            bool resultado = false;

            resultado = senha_correta.Equals(senha);

            if (resultado)
                Console.WriteLine("Senha Correta.");
            else
                Console.WriteLine("Senha Incorreta");


        }


        public void ConfereLogin()
        {
            string login_correto = "karlavf28";
            bool resultado = false;


            resultado = login_correto.Equals(login);

            if (resultado)
                Console.WriteLine("Login Correto.");
            else
                Console.WriteLine("Este Login nao existe");

        }
    }
}
