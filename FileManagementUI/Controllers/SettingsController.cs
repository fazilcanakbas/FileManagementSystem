using Microsoft.AspNetCore.Mvc;

namespace FileManagementUI.Controllers
{
    public class SettingsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}