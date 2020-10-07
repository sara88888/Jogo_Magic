namespace Jogo_Magic
{
    public class Guerreiro:Criatura
    {
        public int CustoTerreno { get; set; }
        public int CustoGeral { get; set; }
        public string NomeCarta { get; set; }

        public Guerreiro() : base()
        {
            NomeCarta = "Guerreiro Veloz";
            CustoTerreno =3;
            CustoGeral = 1;
        }
    }
}
