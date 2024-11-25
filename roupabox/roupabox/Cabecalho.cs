using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace roupabox
{
    internal class Cabec
    {
        public void Cabecalho()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("==========================================");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Autor: Cauã Canale");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("==========================================");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(@"
 
██████╗░░█████╗░██╗░░░██╗██████╗░░█████╗░██████╗░░█████╗░██╗░░██╗
██╔══██╗██╔══██╗██║░░░██║██╔══██╗██╔══██╗██╔══██╗██╔══██╗╚██╗██╔╝
██████╔╝██║░░██║██║░░░██║██████╔╝███████║██████╦╝██║░░██║░╚███╔╝░
██╔══██╗██║░░██║██║░░░██║██╔═══╝░██╔══██║██╔══██╗██║░░██║░██╔██╗░
██║░░██║╚█████╔╝╚██████╔╝██║░░░░░██║░░██║██████╦╝╚█████╔╝██╔╝╚██╗
╚═╝░░╚═╝░╚════╝░░╚═════╝░╚═╝░░░░░╚═╝░░╚═╝╚═════╝░░╚════╝░╚═╝░░╚═╝");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("==============================");
            Console.ResetColor();
        }
    }
}