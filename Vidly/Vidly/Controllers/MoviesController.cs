using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.Models.ViewModel;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shirek" };
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"}
            };

            var RandomMovieViewModel = new RandomMovieViewModel()
            {
                Customer = customers,
                Movie = movie
            };

            #region Passing Data to Views
            /*  Passing Data to Views
             *
             * 1. ViewData["RandomMovieViewModel"] = RandomMovieViewModel;
             * 2. ViewBag.Movie = movie;
             * 3. return View(RandomMovieViewModel);
             *
             * Avoid using ViewData and ViewBag because they are fragil. Plus, you have to do extra casting,
             * which makes your code ugly. Pass a model(or a view model) directly to a view:
             * return View(RandomMovieViewModel);
            */
            #endregion

            return View(RandomMovieViewModel);
            
            #region ActionResult Types
            //return Content("Hellow world");
            //return PartialView();
            //return HttpNotFound();
            //return new EmptyResult();
            //returm RedirectToAction("intex", "Home", new {page = 1, Sortby = "name"});
            # endregion

        }

        public ActionResult Edit(int id)
        {
            return Content($"Id: {id}");
        }

        #region Regulare Expression description
        /* Regulare expression description
         Route is an attribut route that is used to route the request.
         Regular expression: A regular expression is a pattern that the regular expression engine attempts to match in input text.
         ex
            - In {Year:regex(2018|2017)} regex(2018|2017) is a regular expression inforcing the year should only be 2018 or 2017
            - In {Month:regex(\\d{2}):range(1,12)} regex(\\d{2}) and range(1,12) is a regular expression inforcing the month should 
              only be a two digite input
         */ 
        #endregion
        [Route("movies/ByRelease/{Year:regex(2018|2017)}/{Month:regex(\\d{2}):range(1,12)}")]
        public ActionResult ByRelease(int year, byte month)
        {
            return Content($"Release Year Year: {year}/{month}");
        }
    }
}