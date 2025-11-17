using Microsoft.AspNetCore.Mvc;
using Struktura_Projektit.Models;

namespace Struktura_Projektit.Controllers
{
    public class BooksController : Controller
    {
        public BooksController()
        {

        }

        public IActionResult Index()
        {
            return View(BooksManager.GetBooks());
        }

        public IActionResult Details(int id)
        {
            var book = BooksManager.GetById(id);
            return View(book);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new BookAddDTO());
        }

        [HttpPost]
        public IActionResult Create(BookAddDTO model)
        {
            if (ModelState.IsValid)
            {
                BooksManager.AddBook(new Book
                {
                    Author = model.Authori,
                    Price = model.Price,
                    Title = model.Title,
                });
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }
    }
}
