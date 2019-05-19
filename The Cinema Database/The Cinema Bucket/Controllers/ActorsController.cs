using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using The_Cinema_Bucket;
using The_Cinema_Bucket.Models;

namespace The_Cinema_Bucket.Controllers
{
    public class ActorsController : Controller
    {
        // GET: Actors
        private  DbModel Db;
        public ActorsController()
        {
            Db = new DbModel();
        }


        public ActionResult Actors()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Actors(Actors actors)
            {

            Db.actor.Add(actors);
            Db.SaveChanges();
            return View();
        }
    }
}