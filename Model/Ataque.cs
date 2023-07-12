namespace BatalhaRPG.Model
{
    public class Ataque
    {
        public string Nome { get; set; }
        public int Dano { get; set; }

        public Ataque(string nome, int dano)
        {
            Nome = nome;
            Dano = dano;
        }
    }
}
