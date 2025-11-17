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
                    Name= model.Name,
                    Birthplace=model.Birthplace,

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
