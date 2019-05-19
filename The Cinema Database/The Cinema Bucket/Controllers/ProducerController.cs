using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using The_Cinema_Bucket.Models;

namespace The_Cinema_Bucket.Controllers
{
    public class ProducerController : Controller
    {
        // GET: Producer
        private DbModel Db;
        public ProducerController()
        {
            Db = new DbModel();
        }


        public ActionResult Producer()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Producer(Producers producers)
        {
            Db. producer.Add(producers);
            Db.SaveChanges();
            return View();
        }
    }
}