using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SalesWebMvc.Models;

namespace SalesWebMvc.Controllers
{
    public class DepartmentsController : Controller
    {
        public IActionResult Index()
        {

            List<Departaments> list = new List<Departaments>();
            list.Add(new Departaments { Id = 1, Name = "Eletronicos" });
            list.Add(new Departaments { Id = 2, Name = "Fashion" });

            return View(list);
        }
    }
}