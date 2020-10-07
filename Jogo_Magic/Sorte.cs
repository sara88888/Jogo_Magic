namespace Jogo_Magic
{
    public class Sorte:Artefacto
    {
        public string Efeito1 { get; set; }
        public string Efeito2 { get; set; }
        public string NomeCarta { get; set; }

        public Sorte() : base()
        {
            NomeCarta = "Sorte Grande";
            Efeito1 = "Soma 5 à quantidade de Mana disponível do jogador";
            Efeito2 = "Subtrai 1 à quantidade de Mana do adversário";
        }
    }
}
