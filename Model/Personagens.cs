using BatalhaRPG.Interfaces;
using BatalhaRPG.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BatalhaRPG.Model
{
    public class Personagens : IPersonagens
    {
        private readonly List<Personagem> _personagens;
        private readonly Random _random;

        public Personagens()
        {
            _personagens = new List<Personagem>();
            _random = new Random();

            CarregarPersonagens();
        }

        private void CarregarPersonagens()
        {
            var worion = new Personagem("Worion", 25, 32, 500, 300);
            worion.NomesMagia.Add(new Magia("Mil cortes", 5, 60));
            worion.NomesMagia.Add(new Magia("Congelamento extremo", 8, 60));
            worion.NomesMagia.Add(new Magia("Furacão devastador", 10, 60));
            worion.NomesMagia.Add(new Magia("Proteção desconhecida", 3, 100));
            worion.NomesMagia.Add(new Magia("Luz divina", 6, 60));
            worion.NomesMagia.Add(new Magia("Fogo das trevas", 7, 60));
            worion.NomesAtaques.Add(new Ataque("Espada milagrosa", 3));
            worion.NomesAtaques.Add(new Ataque("Explosão mágica", 4));
            worion.NomesAtaques.Add(new Ataque("Fumaça venenosa", 2));
            worion.ImageUrl = "https://th.bing.com/th/id/OIG.UXJgZNmODfhhqxbBEMZB?pid=ImgGn";
            _personagens.Add(worion);

            var murderMonster = new Personagem("MurderMonster", 20, 27, 300, 300);
            murderMonster.NomesMagia.Add(new Magia("Sombras atormentadoras", 5, 60));
            murderMonster.NomesMagia.Add(new Magia("Chamas malignas", 8, 60));
            murderMonster.NomesMagia.Add(new Magia("Vingança das almas", 10, 60));
            murderMonster.NomesMagia.Add(new Magia("Som do submundo", 3, 60));
            murderMonster.NomesAtaques.Add(new Ataque("Fúria obscura", 3));
            murderMonster.NomesAtaques.Add(new Ataque("Poeira do inferno", 4));
            murderMonster.NomesAtaques.Add(new Ataque("Gosma ácida", 2));
            murderMonster.ImageUrl = "https://th.bing.com/th/id/OIG.KDBC8Xobm0Uj4dODCjP4?pid=ImgGn";
            _personagens.Add(murderMonster);

            var hiris = new Personagem("Hiris", 20, 27, 300, 300);
            hiris.NomesMagia.Add(new Magia("Estacas de gelo", 5, 60));
            hiris.NomesMagia.Add(new Magia("Frio eterno", 8, 60));
            hiris.NomesMagia.Add(new Magia("Tornado paralisante", 10, 60));
            hiris.NomesMagia.Add(new Magia("Rajadas de vento", 3, 60));
            hiris.NomesAtaques.Add(new Ataque("Espada venenosa", 3));
            hiris.NomesAtaques.Add(new Ataque("Flecha venenosa", 4));
            hiris.NomesAtaques.Add(new Ataque("Pó venenoso", 2));
            hiris.ImageUrl = "https://th.bing.com/th/id/OIG.U4gLnt_KdwpMWp1rteib?pid=ImgGn";
            _personagens.Add(hiris);

            var delmon = new Personagem("Delmon", 20, 27, 300, 300);
            delmon.NomesMagia.Add(new Magia("Explosão mística", 5, 60));
            delmon.NomesMagia.Add(new Magia("Invasão das trevas", 8, 60));
            delmon.NomesMagia.Add(new Magia("Asas dos ventos sem limites", 10, 60));
            delmon.NomesMagia.Add(new Magia("Erupção Planetária", 3, 60));
            delmon.NomesMagia.Add(new Magia("Tempestade de fogo", 3, 60));
            delmon.NomesAtaques.Add(new Ataque("Lança mística", 3));
            delmon.NomesAtaques.Add(new Ataque("Anel da cura", 4));
            delmon.NomesAtaques.Add(new Ataque("Tornado ardente", 2));
            delmon.ImageUrl = "https://th.bing.com/th/id/OIG.._cKNA4ofUUWccwn26bj?pid=ImgGn";
            _personagens.Add(delmon);

            var dragunn = new Personagem("Dragunn", 20, 27, 300, 300);
            dragunn.NomesMagia.Add(new Magia("Chamas infinitas", 5, 60));
            dragunn.NomesMagia.Add(new Magia("Furacão de fogo", 8, 60));
            dragunn.NomesMagia.Add(new Magia("Vento mortal", 10, 60));
            dragunn.NomesMagia.Add(new Magia("Bola de fogo", 3, 60));
            dragunn.NomesAtaques.Add(new Ataque("Garras de dragão", 3));
            dragunn.NomesAtaques.Add(new Ataque("Bafo poderoso", 4));
            dragunn.NomesAtaques.Add(new Ataque("Gosma venenosa", 2));
            dragunn.ImageUrl = "https://th.bing.com/th/id/OIG.WP9rWkO7Zc3ax3hv8Gal?pid=ImgGn";
            _personagens.Add(dragunn);

            var nirmur = new Personagem("Nirmur", 20, 27, 300, 300);
            nirmur.NomesMagia.Add(new Magia("Raios mortais", 5, 60));
            nirmur.NomesMagia.Add(new Magia("Asteróides de fogo", 8, 60));
            nirmur.NomesMagia.Add(new Magia("Chuva venenosa", 10, 60));
            nirmur.NomesMagia.Add(new Magia("Tormento fantasma", 3, 60));
            nirmur.NomesAtaques.Add(new Ataque("Espada infernal", 3));
            nirmur.NomesAtaques.Add(new Ataque("Chute voador", 4));
            nirmur.NomesAtaques.Add(new Ataque("Ataque elétrico", 2));
            nirmur.ImageUrl = "https://th.bing.com/th/id/OIG.YHF0sQQ1QUCM8pRWxDTi?pid=ImgGn";
            _personagens.Add(nirmur);
        }

        public Personagem GetPersonagem()
        {
            return _personagens[_random.Next(_personagens.Count)];
        }

        public Personagem Dano()
        {
            

            return _personagens[_random.Next(_personagens.Count)];
        }

    }

}
