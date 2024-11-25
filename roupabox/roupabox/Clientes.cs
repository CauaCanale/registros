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
        List <ClienteCad> listaClientes = new List<ClienteCad> ();
        public ClienteCad cadCliente()
        {
            Console.Clear();
            Console.WriteLine("Cadastro de Clientes");
            Console.WriteLine("\nDigite o nome completo do cliente: ");
            string nomeCli = Console.ReadLine();
            var Cliente = new ClienteCad(nomeCli);

            Console.WriteLine("\n Digite o CPF do cliente: ");
            string cpfCli = Console.ReadLine();
            Cliente.cpfCli = cpfCli;
            while (cpfCli.Length != 11 || !cpfCli.All(char.IsDigit))
            {
                Console.WriteLine("CPF invalido. faz de novo!");
                cpfCli = Console.ReadLine();
            }

            Console.WriteLine("\n Digite o Telefone do cliente: ");
            string telCli = Console.ReadLine();
            Cliente.telCli = telCli;

            Console.WriteLine("\n Digite o Idade do cliente: ");
            int idadeCli = int.Parse(Console.ReadLine());
            Cliente.idaCli = idadeCli;

            Console.WriteLine("\n Digite o E-mail do cliente: ");
            string mailCli = Console.ReadLine();
            Cliente.mailCli = mailCli;

            Console.WriteLine("\n Digite o Sexo caso tenha: ");
            string sexCli = Console.ReadLine();
            Cliente.sexCli = sexCli;

            Console.WriteLine("\n Digite a rua da casa do cliente: ");
            string ruaCli = Console.ReadLine();
            Cliente.ruaCli = ruaCli;

            Console.WriteLine("\n Digite o complemento do cliente: ");
            string compleCli = Console.ReadLine();
            Cliente.compleCli = compleCli;

            Console.WriteLine("\n Digite o numero da casa do cliente: ");
            int numCli = int.Parse(Console.ReadLine());
            Cliente.numCli = numCli;

            Console.WriteLine("\n Digite o estado do cliente: ");
            string estaCli = Console.ReadLine();
            Cliente.estaCli = estaCli;

            Console.WriteLine("\n Digite o CEP do cliente: ");
            string cepCli = Console.ReadLine();
            Cliente.cepCli = cepCli;

            listaClientes.Add(Cliente);
            Console.Clear();
            Console.WriteLine($"Cliente cadastrado com sucesso!!!");
           
            //varmenu.Menu();

            return Cliente;
        }

        public void listarCliente()
        {
            Console.Clear();
            Console.WriteLine("Lista de Clientes Cadastrados");
            foreach (var Clientes in listaClientes)
            {
                Console.WriteLine($"Nome: {Clientes.nomeCli}, " + $"cpf: {Clientes.cpfCli}");
            }
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal.");
            Console.ReadKey();
            Console.Clear();


            Cabec variavelCabecalho = new Cabec();
            variavelCabecalho.Cabecalho();

            ExibirMenu varmenu = new ExibirMenu();

        }
    }
}