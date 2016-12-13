using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.Ajax.Utilities;
using MovieRental.Models;
using MovieRental.ViewModels;

namespace MovieRental.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };

            /*ViewData[/Movie"] = movie;  //每个cotroller都有ViewData属性，类型是ViewDataDictionary*/
            var customers = new List<Customer>
            {
                new Customer {Name = "Customer 1"},
                new Customer {Name = "Customer 2"},
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);

            //return Content("Hello World!");
            //return HttpNotFound();
            //return new EmptyResult();
            //return RedirectToAction("Index", "Home",new { page = 1, sortBy = "name" });
        }

        public ActionResult Edit(int movieId)
        {
            //id是default value
            return Content("id=" + movieId);
        }

       
        [Route("movies/released/{year:regex(\\d{4})}/{month:range(1, 12)}")]
        public ActionResult ByReleaseYear(int year, int month)
        {
            return Content(year+"/"+month);
        }
    }
}