using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Magic
{
    public class Magica:Carta
    {
        public int CustoGeral { get; set; }
        public string Efeito1 { get; set; }
        public string NomeCarta { get; set; }
        public string CorCarta { get; set; }

        public Magica() : base("Um_Turno_Só")
        {
            NomeCarta="Mágica Instantânea";
            NovaCarta();
            CustoGeral = 8;
            Efeito1 = "Metade do grimório do adversário sai de jogo";
        }

        public override void NovaCarta()
        {
            CorCarta = string.Empty;
        }
    }
}
