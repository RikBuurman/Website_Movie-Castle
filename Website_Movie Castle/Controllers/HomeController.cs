using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Website_Movie_Castle.Models;
using MySql.Data;
using Website_Movie_Castle.Database;

namespace Website_Movie_Castle.Controllers
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
            // alle producten ophalen
            var rows = DatabaseConnector.GetRows("select * from films");

            // lijst maken om alle namen in te stoppen
            List<string> names = new List<string>();

            foreach (var row in rows)
            {
                // elke naam toevoegen aan de lijst met namen
                names.Add(row["naam"].ToString());
            }

            // de lijst met namen in de html stoppen
            return View(names);
            
        }
        [Route("Films")]
        public IActionResult Films()
        {
            return View();
        }

        [Route("Aboutus")]
        public IActionResult Aboutus()
        {
            return View();
        }
        [Route("Contact")]
        public IActionResult Contact()
        {
            return View();
        }


        [Route("Avatar_Way_of_Water")]
        public IActionResult Avatar_Way_of_Water()
        {
            return View();
        }

        [Route("Little_Mermaid")]
        public IActionResult Little_Mermaid()
        {
            return View();
        }

        [Route("Guardians_of_The_Galaxy")]
        public IActionResult Guardians_of_The_Galaxy()
        {
            return View();
        }

        [Route("Puss_In_Boots")]
        public IActionResult Puss_In_Boots()
        {
            return View();
        }

        [Route("Avengers_endgame")]
        public IActionResult Avengers_endgame()
        {
            return View();
        }

        [Route("Tickets")]
        public IActionResult Tickets()
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