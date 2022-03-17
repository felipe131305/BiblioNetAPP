using BiblioNetAPP.Models;
using Microsoft.AspNetCore.Mvc;

namespace BiblioNetAPP.Controllers
{
    public class BookNameController : Controller
    {
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(BookNameModel bookModel)
        {
            if (!ModelState.IsValid)
            {
                return View(bookModel);
            }
            return View();

        }
    }
}
