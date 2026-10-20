using Microsoft.AspNetCore.Mvc;

namespace Bai_2__N20_11_.Controllers
{
    public class HelloWorldController : Controller
    {
        // 
        // GET: /HelloWorld/

        public string Index()
        {
            return "This is my default action...";
        }

        public String Welcome(int id, string name)
        {
            return $"This is {id} - {name} the Welcome action method...";
        }

        public IActionResult Welcome1(int id1,string name) {
            return View();
        }

      

    }
}