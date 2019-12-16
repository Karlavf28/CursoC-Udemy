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


          while(int.Parse(opcao)!=4)
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
            Console.Write("Digite sua opcao:");

        }


        static void VerificaOpcao(string Opcao)
        {

            if (int.Parse(Opcao) == 1)
            {
                
                Opcao_Usuario();
                TelaInicial();

            }
            else if (int.Parse(Opcao) == 2)
            {
                Soma();
                TelaInicial();

            }
            else if(int.Parse(Opcao) == 3)
            {
                Opcao_Triangulo();
                TelaInicial();
            }
            else
            {
                Console.WriteLine("Finalizando");

            }

           
        }

        static void Opcao_Usuario()
        {
            Usuario x;

            Console.WriteLine();

            x = new Usuario();
            x.ConfereLogin();
            x.ConfereSenha();

        }

        static void Soma()
        {
            double num_A;
            double num_B;
            double resultado = 0;

            Console.WriteLine();

            Console.WriteLine("Digite o primeiro numero");
            num_A = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero");
            num_B = double.Parse(Console.ReadLine());

            resultado = num_A + num_B;

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
    }
    }
