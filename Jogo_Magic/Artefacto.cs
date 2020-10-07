namespace Jogo_Magic
{
    public class Artefacto:Carta
    {
        public int CustoGeral { get; set; }
        public string CorCarta { get; set; }

        public Artefacto() : base("Artefacto")
        {
            NovaCarta();
            CustoGeral = 6;
        }

        public override void NovaCarta()
        {
            CorCarta = string.Empty;
        }
    }
}
