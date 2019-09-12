using Microsoft.AspNetCore.Mvc;
using DataBase.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace DataBase.Controllers
{
    public class StylistController : Controller
    {
        private readonly DataBaseContext _db;
        public StylistController(DataBaseContext db)
        {
            _db = db;
        }


        public ActionResult Index()
        {
            List<Stylist> model = _db.Stylists.ToList();
            return View(model);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Stylist stylist)
        {
            _db.Stylists.Add(stylist);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Stylist stylist = _db.Stylists.FirstOrDefault(sty => sty.StylistId == id);
            List<Client> clientList = _db.Clients.Where(clients => clients.StylistId == id).ToList();
            ViewBag.clientList = clientList;
            return View(stylist);
        }
    }
}