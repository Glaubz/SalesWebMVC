using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMVC.Models;

namespace SalesWebMVC.Controllers
{
    public class DepartamentosController : Controller
    {
        public IActionResult Index()
        {
            List<Departamento> lista = new List<Departamento>();

            lista.Add(new Departamento{ ID = 1, Nome = "Jogos" });
            lista.Add(new Departamento { ID = 2, Nome = "Placa de vídeo" });

            return View(lista);
        }
    }
}
