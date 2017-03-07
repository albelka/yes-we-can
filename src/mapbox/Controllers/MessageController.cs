using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mapbox.Models;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace mapbox.Controllers
{
    public class MessageController : Controller
    {
        private YesWeCanContext db = new YesWeCanContext();

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult newMessage(Message message)
        {
            db.Messages.Add(message);
            db.SaveChanges();
            return Json(message);
        }
    }
}
