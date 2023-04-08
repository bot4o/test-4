using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting.Internal;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Xml.Schema;
using WebApplication7.Data;
using WebApplication7.Models;

namespace WebApplication7.Controllers
{
    public class BookController : Controller //bookcategory
    {
        private readonly BookDbContext _db;

        public BookController(BookDbContext db)
        {
            this._db = db;
        }
        public IActionResult Index()
        {
            var objlist = _db.Book.ToList();
            return View(objlist);
        }

        public IActionResult Create()
        {
            //GET - CREATE
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Book obj)
        {
            //POST - CREATE
            _db.Book.Add(obj);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
