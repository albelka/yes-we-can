﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using mapbox.Models;
using System.Diagnostics;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace mapbox.Controllers
{
    public class MessageController : Controller
    {
        private YesWeCanContext db = new YesWeCanContext();

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(db.Messages.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult newMessage(Message message)
        {
            Debug.WriteLine(message);
            db.Messages.Add(message);
            db.SaveChanges();
            return View("Index", db.Messages.ToList());
        }

        public IActionResult Delete(int id)
        {
            Message thisMessage = db.Messages.FirstOrDefault(j => j.Id == id);
            return View(thisMessage);
        }
        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            Message thisMessage = db.Messages.FirstOrDefault(j => j.Id == id);
            db.Messages.Remove(thisMessage);
            db.SaveChanges();
            return View("Index", db.Messages.ToList());
        }
    }
}