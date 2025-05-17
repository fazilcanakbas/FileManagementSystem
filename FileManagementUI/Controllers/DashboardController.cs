using Microsoft.AspNetCore.Mvc;

namespace FileManagementUI.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}