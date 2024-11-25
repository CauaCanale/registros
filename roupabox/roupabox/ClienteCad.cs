using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Roupabox
{
    internal class ClienteCad
    {
        public ClienteCad(string Cli)
        {
            nomeCli = Cli;
        }
        public string cpfCli { get; set; }
        public string nomeCli { get; set; }
        public string telCli { get; set; }
        public int idaCli { get; set; }
        public string mailCli { get; set; }
        public string sexCli { get; set; }
        public string ruaCli { get; set; }
        public string compleCli { get; set; }
        public int numCli { get; set; }
        public string estaCli { get; set; }
        public string cepCli { get; set; }
    }
}