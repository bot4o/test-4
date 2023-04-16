﻿using Microsoft.AspNetCore.Mvc;
using MovieStoreMvc.Repositories.Abstract;

namespace MovieStoreMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly IBookService _bookService;
        public HomeController(IBookService bookService)
        {
            _bookService = bookService;
        }
        public IActionResult Index(string term="", int currentPage = 1)
        {
            var books = _bookService.List(term,true,currentPage);
            return View(books);
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult BookDetail(int bookId)
        {
            var book = _bookService.GetById(bookId);
            return View(book);
        }

    }
}
