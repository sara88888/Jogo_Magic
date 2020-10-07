namespace Jogo_Magic
{
    public abstract class Carta
    {
        public string TipoCarta { get; set; }

        public Carta(string tipoCarta)
        {
            TipoCarta = tipoCarta;
        }

        public abstract void NovaCarta();
    }
}
