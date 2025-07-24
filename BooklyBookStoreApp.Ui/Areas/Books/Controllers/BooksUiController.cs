using Microsoft.AspNetCore.Mvc;

namespace BooklyBookStoreApp.Ui.Areas.Books.Controllers
{
    public class BooksUiController : Controller
    {
        [Area("Books")]

        public IActionResult Index()
        {
            return View();
        }
    }
}
