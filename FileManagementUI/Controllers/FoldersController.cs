using Microsoft.AspNetCore.Mvc;

namespace FileManagementUI.Controllers
{
    public class FoldersController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}