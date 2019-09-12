using Microsoft.AspNetCore.Mvc;
using DataBase.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DataBase.Controllers
{
    public class ClientController : Controller {

        private readonly DataBaseContext _db;

        public ClientController(DataBaseContext db){
            _db = db;
        }

        public ActionResult Create(int id)
        {
            Stylist s =_db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id);
            return View(_db.Stylists.FirstOrDefault(stylist => stylist.StylistId == id));
        }

        [HttpPost]
        public ActionResult Create(Client client)
        {
            _db.Clients.Add(client);
            _db.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

    }
} 