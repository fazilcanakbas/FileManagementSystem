using Microsoft.AspNetCore.Mvc;

namespace FileManagementUI.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}