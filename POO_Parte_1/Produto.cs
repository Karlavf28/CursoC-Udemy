using System;
using System.Globalization;


namespace Modelo_Console_POO
{
    public class Produto
    {
        public string Nome;
        public string Codigo;
        public double Valor;
        public int Quantidade;

        public Produto()
        {
            Console.WriteLine("Digite o nome do Produto a ser cadastrado:");
            Nome = Console.ReadLine();

            Console.WriteLine("Digite o Codigo do Produto:");
            Codigo = Console.ReadLine();

            Console.WriteLine("Digite o Valor do Produto:");
            Valor = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite a quantidade em estoque do Produto:");
            Quantidade = int.Parse(Console.ReadLine());
        }

        public void AdicionarEstoque()
        {
           
            Console.WriteLine("Digite a quantidade a ser adicionada ao estoque:");
            int quantidade_add = int.Parse(Console.ReadLine());
            Quantidade += quantidade_add;
        }

        public void RemoverEstoque()
        {

            Console.WriteLine("Digite a quantidade a ser removida do estoque:");
            int quantidade_add = int.Parse(Console.ReadLine());
            Quantidade -= quantidade_add;
        }

        public double ValorTotalEstoque()
        {

            double valortotal = Quantidade * Valor;
            return valortotal;
        }

        public override string ToString()
        {

            return Nome + " - " + "$" + Valor + " - " + Quantidade + "unidades" + " - Valor total em estoque: " + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
         }
    }
}
