namespace Jogo_Magic
{
    public class Transformer:Artefacto
    {
        public string Efeito1 { get; set; }
        public string Efeito2 { get; set; }
        public string NomeCarta { get; set; }

        public Transformer() : base()
        {
            NomeCarta = "Transformer";
            Efeito1 = "Iguala uma criatura dos pântanos à escolha do jogador";
            Efeito2 = "Duplica os pontos atacantes da criatura";
        }
    }
}
