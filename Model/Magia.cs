namespace BatalhaRPG.Model
{
    public class Magia
    {
        public string Nome { get; set; }
        public int Poder { get; set; }
        public int CustoMana { get; set; }

        public Magia(string nome, int poder, int custoMana)
        {
            Nome = nome;
            Poder = poder;
            CustoMana = custoMana;
        }
    }
}
