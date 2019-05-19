using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using The_Cinema_Bucket.Models;
using The_Cinema_Bucket.ViewModel;

namespace The_Cinema_Bucket.Controllers
{
    public class MovieController : Controller
    {
        private DbModel db;

        public MovieController()
        {
            db=new DbModel();
        }

        public ActionResult Index()
        {
            movie movies = new movie
            {
                lisstMovies = db.movies.ToList()
            };
            return View(movies);
        }

        public ActionResult Movies()
        {
            MovieViewModel movies = new MovieViewModel()
            {
                lisstMovies = db.movies.ToList()
            };
            ViewBag.actorlist = db.actor.Select(x => new SelectListItem
            {
                Text = x.name,
                Value = x.id.ToString()

            }).ToList();
           
        
          
            ViewBag.producerlist = db.producer.Select(x => new SelectListItem
            {
               Text = x.name,
               Value = x.id.ToString()
            }).ToList();

            return View(movies);
        }
        [HttpPost]
        public ActionResult Movies(movie movies)
        {
            ViewBag.producerlist = db.producer.Select(x => new SelectListItem
            {
                Text = x.name,
                Value = x.id.ToString()
            }).ToList();
            ViewBag.actorlist = db.actor.Select(x => new SelectListItem
            {
                Text = x.name,
                Value = x.id.ToString()

            }).ToList();

           
                string filename = Path.GetFileName(movies.posterName.FileName);
                string extension = Path.GetExtension(movies.posterName.FileName);
                movies.posterurl = filename;
                movies.posterName.SaveAs(Path.Combine(Server.MapPath("~/moviePoster"), filename));
                db.movies.Add(movies);
                db.SaveChanges();
            

              

        





            return View();
        }


        public ActionResult Edit(int id)
        {
            movie movies = new movie
            {
                lisstMovies = db.movies.Where(x => x.id == id).ToList()

            };
            ViewBag.message = "success";
            return View("Details",movies);
        }

        public ActionResult EditDetails(int id)
        {
           movie movies = new movie();
           movies = db.movies.SingleOrDefault(x => x.id == id);
           

            return PartialView("EditDetails", movies);
        }

        public ActionResult UpdateDetails( movie movies)
        {
            string filename;
            string extension;
            if (ModelState.IsValid)
            {
                var updatemovies = db.movies.SingleOrDefault(x => x.id == movies.id);
                updatemovies.actor1 = movies.actor1;
                updatemovies.actor2 = movies.actor2;
                updatemovies.actor3 = movies.actor3;
                updatemovies.movieName = movies.movieName;
                updatemovies.plot = movies.plot;
                updatemovies.year = movies.year;
                updatemovies.producer = movies.producer;
                if (movies.posterName != null)
                {
                    filename = Path.GetFileName(movies.posterName.FileName);
                    extension = Path.GetExtension(movies.posterName.FileName);
                    movies.posterName.SaveAs(Path.Combine(Server.MapPath("~/moviePoster"), filename));



                    updatemovies.posterurl = filename;
                }

                db.SaveChanges();
               
            }
            return RedirectToAction("Index", "Movie");

        }

        public ActionResult Addactor(MovieViewModel mv)
        {
           Actors actor = new Actors();
            actor.bio = mv.actorBio;
            actor.dob = mv.actorDob;
            actor.sex = mv.actorSex;
            actor.name = mv.actorName;
            db.actor.Add(actor);
            db.SaveChanges();
           return View();
        }
        public ActionResult AddProducer(MovieViewModel mv)
        {
            Producers producers = new Producers();
            producers.bio = mv.producerbio;
            producers.dob = mv.produerDob;
            producers.sex = mv.producerSex;
            producers.name = mv.producerName;
            db.producer.Add(producers);
            db.SaveChanges();
            return View();
        }




    }
}