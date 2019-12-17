using System;
using System.Globalization;

namespace Modelo_Console_POO
{
    class Program
    {
        static void Main(string[] args)
        {

            string opcao = "0";

            Console.WriteLine("Ola. Seja bem vindo ao seu primeiro programa em C# =)");

            TelaInicial();


            opcao = Console.ReadLine();


          while(int.Parse(opcao)!=5)
            {
                VerificaOpcao(opcao);
                opcao = "0";
                opcao = Console.ReadLine();

            }

        }


        static void TelaInicial()
        {
            Console.WriteLine();
            Console.WriteLine("Escolha uma das opcoes abaixo:");
            Console.WriteLine();
            Console.WriteLine("1 - Entrar na sessao restrita com usuario e senha");
            Console.WriteLine("2 - Fazer uma soma de dois numeros");
            Console.WriteLine("3 - Calcular a Area de um Triangulo");
            Console.WriteLine("4 - Cadastrar Cliente");
            Console.WriteLine("5 - Finalizar Programa");
            Console.WriteLine();
            Console.Write("Digite sua opcao:");

        }


        static void VerificaOpcao(string Opcao)
        {

            if (int.Parse(Opcao) == 1)
            {
                
                Opcao_Acesso_Restrito();
                
                TelaInicial();

            }
            else if (int.Parse(Opcao) == 2)
            {
                Opcao_Soma();
                TelaInicial();

            }
            else if(int.Parse(Opcao) == 3)
            {
                Opcao_Triangulo();
                TelaInicial();
            }
            else if(int.Parse(Opcao)== 4 )
            {
                Opcao_Cadastro_Cliente();
                TelaInicial();
            }
            else
            {
                Console.WriteLine("Finalizando");

            }

           
        }

        static void Opcao_Acesso_Restrito()
        {
            Usuario x;

            Console.WriteLine();

            x = new Usuario();
            x.ConfereLogin();
            x.ConfereSenha();

            if (x.ok_senha && x.ok_login)
            {
                Produto y;
                y = new Produto();


                y.AdicionarEstoque();
                y.RemoverEstoque();

                Console.WriteLine("Resumo do estoque: " + y);
            }
            else
                Console.WriteLine("Acesso Negado");

        }

        static void Opcao_Soma()
        {
            double num_A;
            double num_B;
            double resultado = 0;

            Console.WriteLine();

            Console.WriteLine("Digite o primeiro numero");
            num_A = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero");
            num_B = double.Parse(Console.ReadLine());

            resultado = Calculadora.Soma(num_A, num_B);

            Console.WriteLine("Resultado da Soma:");

            Console.WriteLine(resultado.ToString("F3", CultureInfo.InvariantCulture));


        }

        static void Opcao_Triangulo()
        {
            Triangulo y;

            Console.WriteLine();

            y = new Triangulo();
      
            double area = y.Area();

            Console.WriteLine();

            Console.WriteLine("A area do triangulo e " + area.ToString("F2", CultureInfo.InvariantCulture));


        }

        static void Opcao_Cadastro_Cliente()
        {
            
            Cliente exemplo, atual;

            exemplo = new Cliente("Carlos", "32342334", "16/06/90", "carlos@gmail.com");
            atual = new Cliente();
           

            Console.WriteLine("Digite 1 para cadastro simples, 2 para cadastro completo ou 3 para ver exemplo");
            string resposta = Console.ReadLine();

            if(resposta == "1")
            {
                atual.CadastroSimples();
                Console.WriteLine();

                Console.WriteLine("Cliente Cadastrado: ");
                atual.ConferirDadosCliente();
                Console.WriteLine();

            }
            else if(resposta=="2")
            {
                atual.CadastroCompleto();
                Console.WriteLine();

                Console.WriteLine("Cliente Cadstrado: ");
                atual.ConferirDadosCliente();
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Exemplo de cadastro completo: ");
                exemplo.ConferirDadosCliente();
                Console.WriteLine();
            }
            
        }
    }
    }
