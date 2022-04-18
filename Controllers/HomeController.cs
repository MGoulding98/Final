using Final.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Final.Controllers
{
    public class HomeController : Controller
    {
        private IQuotesRepository _repo { get; set; }

        private Quote quote { get; set; }
        public HomeController(IQuotesRepository temp)
        {
            _repo = temp;
        }

        public IActionResult Index()
        {

            var quotes = _repo.Quotes.OrderBy(x => x.Author).ToList();

            return View(quotes);
        }

        // ADD Quote
        [HttpGet]
        public IActionResult QuoteForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult QuoteForm(Quote q)
        {
            if (ModelState.IsValid)
            {
                _repo.CreateQuote(q);

                return RedirectToAction("Index");
            }
            else
            {
                return View(q);
            }
        }

        //SHOW quote details
        public IActionResult QuoteDetails(int quoteid)
        {
            Quote q = _repo.GetQuote(quoteid);
            return View(q);
        }

        // EDIT Quote
        [HttpGet]
        public IActionResult EditQuote(int quoteid)
        {
            var quote = _repo.GetQuote(quoteid);

            return View("QuoteForm", quote);
        }

        [HttpPost]
        public IActionResult EditQuote(Quote q)
        {
            _repo.EditQuote(q);

            return RedirectToAction("Index");
        }


        // DELETE Quote
        public IActionResult DeleteQuote(int quoteid)
        {
            _repo.DeleteQuote(quoteid);

            return RedirectToAction("Index");
        }
    }
}
