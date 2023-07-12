namespace BatalhaRPG.Model
{
    public class AtaqueViewModel
    {
        public Personagem Personagem { get; set; }
        public Personagem Adversario { get; set; }
        public Ataque Attack { get; set; }
        public int Damage { get; set; }
    }
}
