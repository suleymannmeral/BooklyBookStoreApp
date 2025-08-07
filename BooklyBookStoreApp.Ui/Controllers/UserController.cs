using Microsoft.AspNetCore.Mvc;

namespace BooklyBookStoreApp.Ui.Controllers
{
    public class UserController : Controller
    {
        public IActionResult RegisterPage()
        {
            return View();
        }
    }
}
