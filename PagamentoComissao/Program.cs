using System;
using System.Collections.Generic;
using System.Globalization;
namespace PagamentoComissao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantidade de vendedores cadastrados: ");
            int n = int.Parse(Console.ReadLine());

            Vendedor ven = new Vendedor();

            List<Vendedor> vendedor = new List<Vendedor>();

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Vendedor #" + i + ":");
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Codigo da peca: ");
                int codigo = int.Parse(Console.ReadLine());
                Console.Write("Preco unitario: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Quantidade de peca vendidas: ");
                int quantidade = int.Parse(Console.ReadLine());

                vendedor.Add(new Vendedor(nome, codigo, preco, quantidade));
                Console.WriteLine();
            }
            
            Console.Write("Deseja fazer alteracao na quantidade? Digite o id que vc quer fazer alteracao: ");
            int numero = int.Parse(Console.ReadLine());

            ven = vendedor.Find(x => x.CodigoPeca == numero);

            if(ven != null)
            {
                Console.Write("Digite o novo valor para a quantidade: ");
                int quantidade = int.Parse(Console.ReadLine());
                ven.Quantidade = quantidade;
            }
            else
            {
                Console.WriteLine("Esse Id da peca nao existe");
            }


            Console.Write("Deseja remover algum vendedor ? Digite o Id dele: ");
            numero = int.Parse(Console.ReadLine());
            
            for(int i = vendedor.Count - 1; i >= 0; i--)
            {
                if(vendedor[i].CodigoPeca == numero)
                {
                    vendedor.RemoveAt(i);
                    Console.WriteLine("Usuario excluido com sucesso!");
                }
            }


            Console.WriteLine();
            foreach(Vendedor obj in vendedor)
            {
                Console.WriteLine(obj);
            }


        }
    }
}
