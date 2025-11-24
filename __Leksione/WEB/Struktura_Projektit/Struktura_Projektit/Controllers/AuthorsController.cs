using Microsoft.AspNetCore.Mvc;
using Struktura_Projektit.Models;

namespace Struktura_Projektit.Controllers
{
    public class AuthorsController : Controller
    {
        public IActionResult Index()
        {
            return View(AuthorManager.GetAuthors());
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new AuthorDTO());
        }

        [HttpPost]
        public IActionResult Create(AuthorDTO model)
        {
            if (ModelState.IsValid)
            {
                AuthorManager.AddAuthor(new Author
                {
                    Name = model.Name,
                    Birthplace = model.Birthplace,

                });
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult Details(int id)
        {
            var author = AuthorManager.GetById(id);
            if (author != null)
            {
                return View(author);
            }
            else
            {
                return NotFound();
            }
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var author = AuthorManager.GetById(id);
            if (author == null)
                return NotFound();

            var authorDTO = new AuthorDTO
            {
                Name = author.Name,
                Birthplace = author.Birthplace
            };
            return View(authorDTO);
        }

        [HttpPost]
        public IActionResult Edit(int id, AuthorDTO model)
        {
            var author = AuthorManager.GetById(id);
            if (author == null)
                return NotFound();

            if (ModelState.IsValid)
            {
                author.Name = model.Name;
                author.Birthplace = model.Birthplace;

                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        public IActionResult Delete(int id)
        {
            var author = AuthorManager.GetById(id);
            if (author == null)
                return NotFound();

            AuthorManager.DeleteAuthor(id);
            return RedirectToAction("Index");
        }
    }
}
