namespace Jogo_Magic
{
    public class Tritao:Criatura
    {
        public int CustoTerreno { get; set; }
        public int CustoGeral { get; set; }
        public string NomeCarta { get; set; }

        public Tritao() : base()
        {
            NomeCarta = "Tritão dos Mares";
            CustoTerreno = 2;
            CustoGeral = 3;
        }
    }
}
