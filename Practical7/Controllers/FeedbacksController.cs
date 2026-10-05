using Practical7.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Practical7.Controllers
{
    public class FeedbacksController : Controller
    {
        // GET: Feedbacks

       
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Feedback feedback)
        {
            if (ModelState.IsValid)
            {
                return View("Details", feedback);
            }

            return View(feedback);
        }

    }
}