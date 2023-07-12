using BatalhaRPG.Interfaces;
using BatalhaRPG.Model;
using Microsoft.AspNetCore.Mvc;

namespace BatalhaRPG.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPersonagens _personagens;

        public HomeController(IPersonagens personagens)
        {
            _personagens = personagens;
        }

        public IActionResult Index()
        {
            var jogador = _personagens.GetPersonagem();
            var personagemOponente = _personagens.GetPersonagem();

            while (personagemOponente == jogador)
            {
                personagemOponente = _personagens.GetPersonagem();
            }

            ViewBag.PersonagemOponente = personagemOponente;

            return View(jogador);
        }

        [HttpPost]
        public IActionResult Index(int opcao)
        {
            // Lógica para processar a opção escolhida
            // Aqui você pode usar a variável "opcao" para determinar qual ataque ou magia foi escolhido

            // Obtém o personagem atual do jogador
            var jogador = _personagens.GetPersonagem();

            // Exemplo de lógica para obter o ataque ou magia escolhido
            if (opcao <= jogador.NomesAtaques.Count)
            {
                var ataqueEscolhido = jogador.NomesAtaques[opcao - 1];
                // Faça algo com o ataque escolhido
            }
            else if (opcao <= jogador.NomesAtaques.Count + jogador.NomesMagia.Count)
            {
                var magiaEscolhida = jogador.NomesMagia[opcao - jogador.NomesAtaques.Count - 1];
                // Faça algo com a magia escolhida
            }
            else
            {
                // A opção escolhida é inválida
                // Lógica para tratar erro ou mostrar mensagem ao jogador
            }

            // Restante da lógica do jogo

            var personagemOponente = _personagens.GetPersonagem();

            while (personagemOponente == jogador)
            {
                personagemOponente = _personagens.GetPersonagem();
            }

            ViewBag.PersonagemOponente = personagemOponente;

            return View(jogador);
        }
    }
}
