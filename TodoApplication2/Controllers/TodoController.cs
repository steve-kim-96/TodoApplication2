using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;

namespace TodoApplication2.Controllers
{
    public class TodoController : Controller
    {
        // GET: /Todo
        public IActionResult Index()
        {
            return View();
        }

        // GET: /Todo/Welcome
        // By default the parameters are received from the URL by the model binder
        // use [FromBody/Header/...] to change default
        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = numTimes;
            return View();
        }
    }
}
