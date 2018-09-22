using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie () {Name = "Shirek"};

            return View(movie);
            //return Content("Hellow world");
            //return PartialView();
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("intex", "Home", new {page = 1, Sortby = "name"});
        }

        public ActionResult Edit(int id)
        {
            return Content($"Id: {id}");
        }

        /* Regulare expression desription
         Route is an attribut route that is used to route the request.
         Regular expression: A regular expression is a pattern that the regular expression engine attempts to match in input text.
         ex
            - In {Year:regex(2018|2017)} regex(2018|2017) is a regular expression inforcing the year should only be 2018 or 2017
            - In {Month:regex(\\d{2}):range(1,12)} regex(\\d{2}) and range(1,12) is a regular expression inforcing the month should 
              only be a two digite input
         */
        [Route("movies/ByRelease/{Year:regex(2018|2017)}/{Month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByRelease(int year, byte month)
        {
            return Content($"Release Year Year: {year}/{month}");
        }
    }
}