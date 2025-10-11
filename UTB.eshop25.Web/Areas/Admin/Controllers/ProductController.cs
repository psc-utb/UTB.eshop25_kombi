using Microsoft.AspNetCore.Mvc;
using UTB.eshop25.Application.Abstraction;

namespace UTB.eshop25.Web.Areas.Admin.Controllers
{
    [Area(nameof(Admin))]
    public class ProductController : Controller
    {
        IProductAppService _productAppService;
        public ProductController(IProductAppService productAppService)
        {
            _productAppService = productAppService;
        }

        public IActionResult Select()
        {
            var products = _productAppService.SelectAll();
            return View(products);
        }
    }
}
