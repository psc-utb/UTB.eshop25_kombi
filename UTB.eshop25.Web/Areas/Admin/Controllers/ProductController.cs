using Microsoft.AspNetCore.Mvc;

namespace UTB.eshop25.Web.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    public class ProductController : Controller
    {
        public IActionResult Select()
        {
            return View();
        }
    }
}
