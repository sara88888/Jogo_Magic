namespace Jogo_Magic
{
    using System;

    public class Terreno:Carta
    {
        public int QttMana { get; set; }
        public string CorTerreno { get; set; }
        public string NomeCarta { get; set; }
        public string CorCarta { get; set; }

        public Terreno() : base("Terreno")
        {
            NovaCarta();
            QttMana = new Random().Next(1, 10);
        }

        public override void NovaCarta()
        {
            int sorteio = new Random().Next(1, 6);
            switch (sorteio)
            {
                case 1:
                    CorCarta = "White";
                    CorTerreno = "Khaki";
                    NomeCarta = "P L A N Í C I E";
                    break;
                case 2:
                    CorCarta = "Blue";
                    CorTerreno = "LightBlue";
                    NomeCarta = "I L H A";
                    break;
                case 3:
                    CorCarta = "Black";
                    CorTerreno = "BurlyWood";
                    NomeCarta = "P Â N T A N O";
                    break;
                case 4:
                    CorCarta = "Red";
                    CorTerreno = "Coral";
                    NomeCarta = "M O N T A N H A";
                    break;
                case 5:
                    CorCarta = "Green";
                    CorTerreno = "PaleGreen";
                    NomeCarta = "F L O R E S T A";
                    break;
                default:
                    break;
            }
        }
    }
}
