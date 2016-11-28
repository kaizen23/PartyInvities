using PartyInvities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartyInvities.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            int hour = DateTime.Now.Hour;
            ViewBag.Greeting = hour < 17 ? "Dzień dobry" : "Dobry wieczor";
            return View();
        }
        [HttpGet]
        public ActionResult RsvpForm()
        {
            return View();
        }
        [HttpPost]
        public ActionResult RsvpForm(GuestResponse guestResponse)
        {
            if (ModelState.IsValid)
            {
                return View("Thanks", guestResponse);
            }
            else
            {
                return View();
            }

        }
    }
}