using DevWS.UI.Site.Data;
using DevWS.UI.Site.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace DevWS.UI.Site.Controllers
{
    public class TesteCrudController : Controller
    {
        private readonly MeuDbContext _contexto;
        public TesteCrudController(MeuDbContext contexto)
        {
            _contexto = contexto;
        }
        public IActionResult Index()
        {
            var aluno = new Aluno()
            {
                Nome = "Carlos Wagner",
                DataNascimento = new DateTime(1990, 8, 15),
                Email = "wagnerSperling@email.com"
            };

            _contexto.Alunos.Add(aluno);
            _contexto.SaveChanges();

            var aluno1 = _contexto.Alunos.Find(aluno.Id);
            var aluno2 = _contexto.Alunos.FirstOrDefault(a => a.Email == "wagnerSperling@email.com");
            var aluno3 = _contexto.Alunos.Where(a => a.Nome == "Carlos Wagner");

            aluno.Nome = "Carlos Sperling";
            _contexto.Alunos.Update(aluno);
            _contexto.SaveChanges();

            _contexto.Alunos.Remove(aluno);
            _contexto.SaveChanges();

            //return RedirectToAction("Index", "Cadastro", new { area = "Produtos" });
            return RedirectToAction("Index", "Home", new { area = "" });
        }
    }
}



