using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppHttp.Controllers
{

    public class ContatoController : Controller
    {
        public IActionResult Index()
        {
            var contatoDto = new ContatoDto()
            {
                DataNascimento = DateTime.Now.ToString(),
                Nome = "Cristiano"
            };
            return View(viewName: "MinhaVisao");
        }

        public class ContatoDto
        {
            public string Nome { get; set; }
            public string DataNascimento { get; set; }

        }

       
    }
}
