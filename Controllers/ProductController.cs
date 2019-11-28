using Microsoft.AspNetCore.Mvc;
using exemplo_mvc_form.Models;

namespace exemplo_mvc_form.Controllers
{
    public class ProductController : Controller
    {

      public IActionResult Save(){
        return View();
      }

      public IActionResult Save(Product product){
        return View();
      }
        
    }
}