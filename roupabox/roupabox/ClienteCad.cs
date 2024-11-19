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
        public string nomeCli { get; set; }
        public string cpfCli { get; set; }
        public string telCli { get; set; }
        public string idaCli { get; set; }
        public string mailCli { get; set; }
        public string sexCli { get; set; }
        public double numCli { get; set; }
        public string baiCli { get; set; }
        public string cidaCli { get; set; }
        public string estaCli { get; set; }
        public string cepCli { get; set; }
    }
}