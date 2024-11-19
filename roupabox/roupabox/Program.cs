using roupabox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roupabox
{
    public class program
    {
        public static void Main(string[] args)
        {
            Cabec variavelCabecalho = new Cabec();
            variavelCabecalho.Cabecalho();

            Produtos varPro = new Produtos();
            Clientes varCli = new Clientes();
            

            ExibirMenu variavelMenu = new ExibirMenu();
            variavelMenu.Menu(varCli);

        }
    }
}
