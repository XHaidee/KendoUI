using KendoUI.Models.FromModel;
using Microsoft.AspNetCore.Mvc;

namespace KendoUI.FromController{
    public class FormController:Controller
    {
        [HttpGet]
        public IActionResult Index(){
            return View();
        }
        [HttpPost]
        public IActionResult Index(Form jsonOBJ) { 
            return View (jsonOBJ);
        }
        public IActionResult FormFroHaideep(){
            return View();
        }
        
    }
}