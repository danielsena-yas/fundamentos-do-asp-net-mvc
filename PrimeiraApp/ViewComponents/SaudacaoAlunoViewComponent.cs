using Microsoft.AspNetCore.Mvc;
using PrimeiraApp.Models;

namespace PrimeiraApp.ViewComponents
{
    public class SaudacaoAlunoViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            // Pega o aluno da base de dados ou pega o nome do aluno logado
            var aluno = new Aluno() { Nome = "Eduardo" };
            return View(aluno);
        }
    }
}
