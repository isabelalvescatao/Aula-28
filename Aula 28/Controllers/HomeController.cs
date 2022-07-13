using Aula_28.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Aula_28.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {      
            List<Alunos> alunos = new List<Alunos>();

            alunos.Add(new Alunos()
            {
                id = 1,
                nome = "Isabel",
                sobrenome = "Catão",
                status = "Reprovado"
            }
            ) ;

            alunos.Add(new Alunos()
            {
                id = 2,
                nome = "Maíra",
                sobrenome = "Oliveira",
                status = "Aprovado"
            }
            );


            alunos.Add(new Alunos()
            {
                id = 3,
                nome = "Ariel",
                sobrenome = "Lopes",
                status = "Recuperação"
            }
            );


            return View(alunos);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


}
}