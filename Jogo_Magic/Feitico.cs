using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jogo_Magic
{
    public class Feitico : Carta
    {
        public int CustoTerreno { get; set; }
        public string CorCustoTerreno { get; set; }
        public string Efeito1 { get; set; }
        public string NomeCarta { get; set; }
        public string CorCarta { get; set; }

        public Feitico() : base("Feitiço")
        {
            NomeCarta = "Contra-Magia";
            NovaCarta();
            CustoTerreno = 4;
            Efeito1 = "Anula todos os efeitos produzidos neste terreno durante o turno do adversário";
        }

        public override void NovaCarta()
        {
            int sorteio = new Random().Next(1, 5);
            switch (sorteio)
            {
                case 1:
                    CorCarta = "White";
                    CorCustoTerreno = "Khaki";
                    break;
                case 2:
                    CorCarta = "DogderBlue";
                    CorCustoTerreno = "LightBlue";
                    break;
                case 3:
                    CorCarta = "Black";
                    CorCustoTerreno = "Tan";
                    break;
                case 4:
                    CorCarta = "Red";
                    CorCustoTerreno = "Coral";
                    break;
                case 5:
                    CorCarta = "ForestGreen";
                    CorCustoTerreno = "PaleGreen";
                    break;
                default:
                    break;
            }
        }
    }
}
