namespace Jogo_Magic
{
    public class Elixir:Artefacto
    {
        public string Efeito1 { get; set; }
        public string Efeito2 { get; set; }
        public string NomeCarta { get; set; }

        public Elixir() : base()
        {
            NomeCarta = "Elixir da Felicidade";
            Efeito1 = "Duplica os pontos de vida do jogador";
            Efeito2 = string.Empty;
        }
    }
}
