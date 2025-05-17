using Microsoft.AspNetCore.Mvc;

namespace FileManagementUI.Controllers
{
    public class FilesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}