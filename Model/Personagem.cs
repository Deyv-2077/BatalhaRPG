using BatalhaRPG.Model;

namespace BatalhaRPG.Model
{


    public class Personagem
    {
        public string Nome { get; set; }
        public int Forca { get; set; }
        public int Defesa { get; set; }
        public int HP { get; set; }
        public int MP { get; set; }
        public List<Ataque> NomesAtaques { get; set; }
        public List<Magia> NomesMagia { get; set; }
        public string ImageUrl { get; set; }


        public Personagem(string nome, int forca, int defesa, int hp, int mp)
        {
            Nome = nome;
            Forca = forca;
            Defesa = defesa;
            HP = hp;
            MP = mp;
            NomesAtaques = new List<Ataque>();
            NomesMagia = new List<Magia>();
        }
    }
}