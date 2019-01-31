using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyMusicStore.Models;
using System.Data.Entity.SqlServer.Utilities;

namespace MyMusicStore.Controllers
{
    public class StoreController : Controller
    {
        MusicStoreEntities storeDB = new MusicStoreEntities();
        // GET: Store


        public ActionResult Index()
        {
            var genres = storeDB.Genres.ToList();
            //var genres = new List<Genre>
            //{
            //    new Genre{Name = "Disco"},
            //new Genre { Name = "Metal" },
            //new Genre{Name ="Rock"}
            //};

            return View(genres);

        }

        public ActionResult Browse(string genre)
        {
            var genreModel = new Genre { Name = genre };

            return View(genreModel);
        }
        //public String Browse(string genre)
        //{
        //    string message = HttpUtility.HtmlEncode("Store Browse, Genre=" + genre);

        //    return message;
        //}

        public ActionResult Details(int id)
        {
            var album = new Album { Title = "Album " + id };

            return View(album);

            //string message = "Store.Details ID = " + id;

            //return message;
        }
    }
}