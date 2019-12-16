﻿using System;
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


        static void ConfereSenha()
        {
            string senha_correta = "2323BB";
            bool resultado = false;


            Console.WriteLine("Digite a senha:");
            string resposta = Console.ReadLine();


            resultado = senha_correta.Equals(resposta);

            if (resultado)
                Console.WriteLine("Senha Correta.");
            else
                Console.WriteLine("Senha Incorreta");



        }

        static void ConfereLogin()
        {
            string login_correto = "karlavf28";
            bool resultado = false;

            Console.WriteLine("Digite o login:");
            string resposta = Console.ReadLine();


            resultado = login_correto.Equals(resposta);

            if (resultado)
                Console.WriteLine("Login Correto.");
            else
                Console.WriteLine("Este Login nao existe");

        }

        static void Soma()
        {
            double num_A;
            double num_B;
            double resultado = 0;


            Console.WriteLine("Digite o primeiro numero");
            num_A = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o primeiro numero");
            num_B = double.Parse(Console.ReadLine());

            resultado = num_A + num_B;

            Console.WriteLine("Resultado da Soma:");

            Console.WriteLine(resultado.ToString("F3", CultureInfo.InvariantCulture));



        }

        static void TelaInicial()
        {
            Console.WriteLine("Escolha uma das opcoes abaixo:"); 
            Console.WriteLine("1 - Entre na secao restrita");
            Console.WriteLine("2 - Fazer uma soma");
            Console.WriteLine("3 - Area do Triangulo");
            Console.WriteLine("Digite sua opcao:");

        }

        static void VerificaOpcao(string Opcao)
        {

            if (int.Parse(Opcao) == 1)
            {
                ConfereLogin();
                ConfereSenha();
                TelaInicial();


            }
            else if (int.Parse(Opcao) == 2)
            {
                Soma();
                TelaInicial();

            }
            else if(int.Parse(Opcao) == 3)
            {
                AreaDoTriangulo();
                TelaInicial();
            }
            else
            {
                Console.WriteLine("Finalizando");

            }

           
        }

        static void AreaDoTriangulo()
        {
            Triangulo x;
            x = new Triangulo();

            Console.WriteLine("Digite os tres lados do Triangulo e aperte enter");
            string Lados = Console.ReadLine();

            string[] vet = Lados.Split(' ');
             x.Medida_A = int.Parse(vet[0]);
             x.Medida_B = int.Parse(vet[1]);
             x.Medida_C = int.Parse(vet[2]);

            double p = (x.Medida_A + x.Medida_B + x.Medida_C)/2.0; //calculo do perimetro

            double area = Math.Sqrt(p * (p - x.Medida_A) * (p - x.Medida_B) * (p - x.Medida_C)); //calculo da area

            Console.WriteLine("A area do triangulo e" + area.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
    }
