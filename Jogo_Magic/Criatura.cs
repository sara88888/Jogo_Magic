namespace Jogo_Magic
{
    using System;

    public class Criatura:Carta
    {
        public string CorCustoTerreno { get; set; }
        public int PontosDano { get; set; }
        public int PontosResist { get; set; }
        public string CorCarta { get; set; }

        public Criatura() : base("Criatura")
        {
            NovaCarta();
            PontosDano = new Random().Next(1, 9);
            PontosResist = new Random().Next(1, 9);
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
