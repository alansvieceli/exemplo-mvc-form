using Microsoft.AspNetCore.Mvc;
using exemplo_mvc_form.Models;

namespace exemplo_mvc_form.Controllers
{
    public class ProductController : Controller
    {
      [HttpGet]
      public IActionResult Save(){
        return View();
      }

      [HttpPost]
      public IActionResult Save(Product product){

        //if ((product.Id == 0) || string.IsNullOrEmpty(product.Name) || (product.Price == 0)){
        if (!ModelState.IsValid){ //isso caso usar o [Required] no DTO
          ViewBag.Validacao = "Produto inválido para cadastro";
          //ViewBag é um utilitario da classe controller
        }

        return View();
      }
        
    }
}