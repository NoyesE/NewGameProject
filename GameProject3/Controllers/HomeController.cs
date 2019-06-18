using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GameProject3.Models;
using System.Text.Encodings.Web;

namespace GameProject3.Controllers
{
    public class HomeController : Controller
    {
        
        public IActionResult Index()
        {
            Player myPlayer = new Player
            {
                Name = "Ian",
                wood = 0,
                lumberHut = 0,
                gatherStrength = 1
            };
            return View(myPlayer);
        }

        public IActionResult gatherWood(Player player)
        {
            
            int wood = Convert.ToInt16(Request.Form["wood"]);
            player.wood = wood + 1 * player.gatherStrength;


            return View(player);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

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
