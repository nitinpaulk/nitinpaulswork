using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TicketTracker.Controllers
{
    public class TicketController : Controller
    {
        // GET: Ticket
        public ActionResult Index()
        {
            return View();
        }
        /// <summary>
        /// To list the tickets
        /// </summary>
        /// <returns></returns>
        public ActionResult ListTickets()
        {
            return View();
        }
    }
}