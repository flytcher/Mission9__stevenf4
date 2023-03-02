using Microsoft.AspNetCore.Mvc;
using Mission9__stevenf4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission9__stevenf4.Controllers
{
    public class HomeController : Controller
    {
        private IBookRepository repo;

        public HomeController (IBookRepository temp)
        {
            repo = temp;
        }
       
        public IActionResult Index()
        {
            var blah = repo.Books.ToList();

            return View();
        }
    }
}
