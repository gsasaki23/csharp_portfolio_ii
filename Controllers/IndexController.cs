using Microsoft.AspNetCore.Mvc;
using System;

namespace portfolio_ii
{
    public class IndexController : Controller
    {
        [HttpGet("")]
        public IActionResult Index()
        {
            return View("Index");
        }
        [HttpGet("projects")]
        public IActionResult Projects()
        {
            return View("Projects");
        }
        [HttpGet("contact")]
        public IActionResult Contact()
        {
            return View("Contact");
        }
        
        // [HttpGet("")]
        // public IActionResult ShowIndex(string Food, int Quantity)
        // {
        //     Console.WriteLine($"I ate {Quantity} {Food}."); // logs in the c# terminal, not the browser console
        //     ViewBag.message = "Hello World!";
        //     return View("Index");
        // }
        
        // [HttpGet("redirect")]
        // public RedirectToActionResult Method()
        // {
        //     // Will redirect to the "ShowIndex" method
        //     // return RedirectToAction("ShowIndex");
            
        //     // Will redirect to the "ShowIndex" method at another controller called "OtherController.cs"
        //     // return RedirectToAction("ShowIndex", "Other");

        //     // Will redirect to the "ShowIndex" method with the "Food" and "Quantity" parameters
        //     var param = new { Food = "sandwiches", Quantity = 5 };
        //     return RedirectToAction("ShowIndex",param);
        // }

        // [HttpGet("{favoriteResponse}")]
        // // IActionResult can be slower but takes care of RedirectToActionResult, ViewResult, or even JSON
        // public IActionResult ItDepends(string favoriteResponse)
        // {
        //     if(favoriteResponse == "Redirect")
        //     {
        //         return RedirectToAction("Index");
        //     }
        //     else if(favoriteResponse == "Json")
        //     {
        //         return Json(new {FavoriteResponse = favoriteResponse});
        //     }
        //     return View();
        // }

    }
}
