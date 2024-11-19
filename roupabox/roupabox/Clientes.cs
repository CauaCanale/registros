using roupabox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roupabox
{
    internal class Clientes
    {
        public ClienteCad CadCliente()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Clientes");
            Console.WriteLine("\nDigite o nome completo do cliente: ");
            string nomeCli = Console.ReadLine();

            Console.WriteLine("\n Digite o CPF do cliente: ");
            string cpfCli = Console.ReadLine();

            // Verifica se o CPF tem exatamente 6 caracteres
            if (cpfCli.Length != 11)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Erro: O numero deve ter exatamente 11 caracteres.");
                Console.ResetColor();              
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("numero  válido.");
                Console.ResetColor();
            }

            Console.WriteLine("\n Digite o nome do cliente: ");
            string nomeCli = Console.ReadLine();
            Produto.nomeCli = nomeCli;

            Console.WriteLine("\n Digite o CPF do cliente: ");
            long cpfCli = long.Parse(Console.ReadLine());
            Produto.cpfCli = cpfCli;

            Console.WriteLine("\n Digite o Telefone do cliente: ");
            long telCli = Console.ReadLine();
            Produto.telCli = telCli;

            Console.WriteLine("\n Digite o Idade do cliente: ");
            int idaCli = Console.ReadLine();
            Produto.idaCli = idaCli;

            Console.WriteLine("\n Digite o E-mail do cliente: ");
            string mailCli = Console.ReadLine();
            Produto.mailCli = mailCli;

            Console.WriteLine("\n Digite o Sexo caso tenha: ");
            string sexCli = Console.ReadLine();
            Produto.sexCli = sexCli;

            Console.WriteLine("\n Digite a rua da casa do cliente: ");
            string ruaCli = int.Parse(Console.ReadLine());
            Produto.ruaCli = ruaCli;

            Console.WriteLine("\n Digite o complemento do cliente: ");
            string compleCli = Console.ReadLine();
            Produto.compleCli = compleCli;

            Console.WriteLine("\n Digite o numero da rua do cliente: ");
            string cidaCli = Console.ReadLine();
            Produto.cidaCli = cidaCli;

            Console.WriteLine("\n Digite o estado do cliente: ");
            string estaCli = Console.ReadLine();
            Produto.estaCli = estaCli;

            Console.WriteLine("\n Digite o CEP do cliente: ");
            int cepCli = int.Parse(Console.ReadLine());
            Produto.cepCli = cepCli;

            Console.WriteLine("\nCliente cadastrado com sucesso!!!");
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
            Console.ReadLine();

            Cabec variavelCabecalho = new Cabec();
            variavelCabecalho.Cabecalho();

            ExibirMenu varmenu = new ExibirMenu();
            //varmenu.Menu();

        }
    }
}