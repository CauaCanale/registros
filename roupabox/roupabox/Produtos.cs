using roupabox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Roupabox
{
    internal class Produtos
    {
        List<ProdutoCad> listaprodutos = new List<ProdutoCad>();


        public ProdutoCad cadProduto()
        {

            Console.Clear();
            Console.WriteLine("Cadastro de Produtos:");

            Console.WriteLine("\n Digite a descrição do produto:");
            string descPro = Console.ReadLine();

            var Produto = new ProdutoCad(descPro);

            Console.WriteLine("\n Digite o nome da marca do produto:");
            string marcaPro = Console.ReadLine();
            Produto.marcaPro = marcaPro;


            Console.WriteLine("\n Digite o tamanho do produto:");
            string tamPro = Console.ReadLine();
            Produto.tamPro = tamPro;


            Console.WriteLine("\n Digite a cor do produto:");
            string corPro = Console.ReadLine();
            Produto.corPro = corPro;


            Console.WriteLine("\n Digite a categoria do produto:");
            string catPro = Console.ReadLine();
            Produto.catPro = catPro;


            Console.WriteLine("\n Digite o valor do produto:");
            double valPro = double.Parse(Console.ReadLine());
            Produto.valPro = valPro;


            Console.WriteLine("\n Digite o peso do produto:");
            double pesoPro = int.Parse(Console.ReadLine());
            Produto.pesoPro = pesoPro;

            listaprodutos.Add(Produto);
            Console.Clear();
            Console.WriteLine($"produto cadastrado com sucesso!!!");

            return Produto;
        }

        public void listarProduto()
        {
            Console.Clear();
            Console.WriteLine("Lista de Produtos Cadastrados");
            foreach (var produto in listaprodutos)
            {
                Console.WriteLine($"Desrição:  {produto.descPro}, " + $"Valor:{produto.valPro} ");
            }
            
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();

            Cabec variavelCabecalho = new Cabec();
            variavelCabecalho .Cabecalho();
            Produtos varPro = new Produtos();
            ExibirMenu exibirMenu = new ExibirMenu();

        }
    }
}
