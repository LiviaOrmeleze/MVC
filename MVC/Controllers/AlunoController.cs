using Microsoft.AspNetCore.Mvc;
using MVC.Models;

namespace MVC.Controllers
{
    public class AlunoController : Controller
    {
        public IActionResult Index()
        {
            Aluno a1 = new Aluno(1, "Livia Modesto Ormeleze", "lormeleze@gmail.com", 3776);
            Aluno a2 = new Aluno(2, "Gabriela Siqueira Caputti", "bibibis@gmail.com", 6773);
            Aluno a3 = new Aluno(3, "Ana Clara de Souza", "aninhafedida@gmail.com", 7736);
            Aluno a4 = new Aluno(4, "Bryan Martins Fusco", "ratinquerqueijo@gmail.com", 7376);
            Aluno a5 = new Aluno(5, "João Pedro Milani", "jpobrabo@gmail.com", 7763);

            //Criar uma lista de Alunos
            List<Aluno> ListaAlunos = new List<Aluno>();
            //Adicionar os Objetos Alunos na Lista Alunos 
            ListaAlunos.Add(a1);
            ListaAlunos.Add(a2);
            ListaAlunos.Add(a3);
            ListaAlunos.Add(a4);
            ListaAlunos.Add(a5);

            //Enviando a lista de Aunos por parametro na View Index
            return View(ListaAlunos);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }
    }
}
