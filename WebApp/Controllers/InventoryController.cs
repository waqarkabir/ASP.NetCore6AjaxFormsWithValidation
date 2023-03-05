using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class InventoryController : Controller
    {
        public IActionResult ProductCreate()
        {
            return View();
        }
    }
}
