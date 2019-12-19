using System;
namespace Modelo_Console_POO
{
    public class Usuario
    {
        public string login;
        public string senha;
        public bool ok_login;
        public bool ok_senha;

        //Construtor
        public Usuario()
        {

            Console.WriteLine("Digite o login:");
            login = Console.ReadLine();
            ConfereLogin();

            Console.WriteLine("Digite a senha:");
            senha = Console.ReadLine();
            ConfereSenha();

        }

        /*Metodos*/

        public void ConfereSenha()
        {
            string senha_correta = "2323BB";
            bool resultado = false;

            resultado = senha_correta.Equals(senha);

            if (resultado)
            {
                Console.WriteLine("Senha Correta.");
                ok_senha = true;
            }
                
            else
            {
                Console.WriteLine("Senha Incorreta");
                ok_senha = false;
            }
                


        }


       public void ConfereLogin()
        {
            string login_correto = "karlavf28";
            bool resultado = false;


            resultado = login_correto.Equals(login);

            if (resultado)
            {
                Console.WriteLine("Login Correto.");
                ok_login = true;
            }
                
            else
            {
                Console.WriteLine("Este Login nao existe");
                ok_login = false;
            }
                

        }
    }
}
