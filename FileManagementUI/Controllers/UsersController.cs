using Microsoft.AspNetCore.Mvc;

namespace FileManagementUI.Controllers
{
    public class UsersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}