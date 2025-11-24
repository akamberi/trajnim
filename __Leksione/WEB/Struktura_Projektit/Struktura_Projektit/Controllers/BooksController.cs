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

        //http get per te marre te dhenat e vjetra te librit me id qe i kalojme
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var book = BooksManager.GetById(id);
            if (book == null)
                return NotFound();

            var model = new BookAddDTO
            {
                Title = book.Title,
                Authori = book.Author,
                Price = book.Price
            };
            return View(model);
        }

        //http post per te derguar te dhenat e reja te librit me id qe i kalojme
        [HttpPost]
        public IActionResult Edit(int id, BookAddDTO model)
        {
            var book = BooksManager.GetById(id);
            if (book == null)
                return NotFound();

            if (ModelState.IsValid)
            {
                book.Title = model.Title;
                book.Author = model.Authori;
                book.Price = model.Price;

                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        //http get per te marre te dhenat e librit qe do fshihet
        [HttpGet]
        public IActionResult Delete(int id)
        {
            var book = BooksManager.GetById(id);
            if (book == null)
                return NotFound();

            return View(book);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult ConfirmedDelete(int id)
        {
            var book = BooksManager.GetById(id);
            if (book == null)
                return NotFound();

            BooksManager.DeleteBook(id);

            return RedirectToAction("Index");
        }
    }
}
