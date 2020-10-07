namespace Jogo_Magic
{
    using System;

    public class Encantamento:Carta
    {
        public int CustoGeral { get; set; }
        public string CorCustoTerreno { get; set; }
        public string Efeito1 { get; set; }
        public string Efeito2 { get; set; }
        public string NomeCarta { get; set; }
        public string CorCarta { get; set; }

        public Encantamento() : base("Encantamento")
        {
            NomeCarta = string.Empty;
            NovaCarta();
            CustoGeral = 4;
            Efeito1="Soma 2 pontos atacantes a qualquer criatura do mesmo terreno descartada";
            Efeito2 = "Soma 4 pontos de resistência às criaturas mencionadas";
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
