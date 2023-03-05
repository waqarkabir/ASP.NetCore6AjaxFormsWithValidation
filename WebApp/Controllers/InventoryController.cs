using Microsoft.AspNetCore.Mvc;
using WebApp.DbModels;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class InventoryController : Controller
    {
        public InventoryDbContext Context { get; }
        public InventoryController(InventoryDbContext context)
        {
            Context = context;
        }


        public IActionResult ProductCreate()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> ProductCreate(ProductCreateVM model)
        {
            if (!ModelState.IsValid)
            {
                return Json("");
            }

            await Context.AddAsync(
                    new Product()
                    { 
                        Title= model.Title,
                        Description= model.Description,
                        CreatedDate= DateTime.Now,
                        IsActive= model.IsActive,
                        Price= model.Price,
                    }
                );
            Context.SaveChanges();

            return Json("Product Created");
        }
    }
}
