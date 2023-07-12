using BatalhaRPG.Model;

namespace BatalhaRPG.Model
{
    public class Adversario
    {
        public string Nome { get; set; }
        public int Forca { get; set; }
        public int Defesa { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public List<Magia> NomesMagia { get; set; }
        public List<Ataque> NomesAtaques { get; set; }

        public Adversario(string nome, int forca, int defesa, int hp, int mp)
        {
            Nome = nome;
            Forca = forca;
            Defesa = defesa;
            HP = hp;
            MP = mp;
            NomesMagia = new List<Magia>();
            NomesAtaques = new List<Ataque>();
        }

        public void ReceberDano(int dano)
        {
            HP -= dano;
            if (HP < 0)
                HP = 0;
        }

        public int? CalcularDano(Ataque ataque)
        {
            return null;

        }


    }
}