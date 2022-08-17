using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Exercicios.Models;

namespace Exercicios.Controllers
{
    public class CondicionaisController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CondicionalIf(){
            return View();
        }

        [HttpPost]
        public IActionResult CondicionalIf(Partida partida){
            return View(partida);
        }
        
    }
}