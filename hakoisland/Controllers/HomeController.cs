using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using hakoisland.Models;
using hakoisland.Domain;
using hakoisland.Data;

namespace hakoisland.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private HakoIslandDbContext _db;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            _db = new HakoIslandDbContext();
        }

        public IActionResult Login(int user, string password, string javamode)
        {
            Console.WriteLine(user + ", " + password);
            
            SignInModel signin = new SignInModel(user, password);
            bool b = signin.ComputeHashSha256();

            Console.WriteLine(b ? "pass" : "fail");
            
            return Ok();
        }

        public async Task<IActionResult> Index()
        {
            IndexViewbuilder _builder = new IndexViewbuilder();
            IndexViewModel viewModel = await _builder.BuildAsync();
            
            ViewData["viewModel"] = viewModel;
            
            return View();
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
