using System;
using System.Globalization;


namespace Modelo_Console_POO
{



    public class Triangulo
    {
        
            public double Medida_A;
            public double Medida_B;
            public double Medida_C;

        public Triangulo()
        {
            Console.WriteLine("Digite os tres lados do Triangulo e aperte enter");
            string Lados = Console.ReadLine();

            string[] vet = Lados.Split(' ');
            Medida_A = int.Parse(vet[0]);
            Medida_B = int.Parse(vet[1]);
            Medida_C = int.Parse(vet[2]);
        }

        public double Area()
        {

            double p = (Medida_A + Medida_B + Medida_C) / 2.0; //calculo do perimetro

            return Math.Sqrt(p * (p - Medida_A) * (p - Medida_B) * (p - Medida_C)); //calculo da area


        }


    }
}
