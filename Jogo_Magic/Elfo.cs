using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Magic
{
    public class Elfo:Criatura
    {
        public int CustoTerreno { get; set; }
        public int CustoGeral { get; set; }
        public string NomeCarta { get; set; }

        public Elfo() : base()
        {
            NomeCarta = "Elfo Voador";
            CustoTerreno = 1;
            CustoGeral = 4;
        }
    }
}
