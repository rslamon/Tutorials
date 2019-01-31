using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMusicStore.Models;

namespace MyMusicStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            var genres = new List<Genre>
            {
                new Genre{Name = "Disco"},
            new Genre { Name = "Metal" },
            new Genre{Name ="Rock"}
            };

            return View(genres);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}