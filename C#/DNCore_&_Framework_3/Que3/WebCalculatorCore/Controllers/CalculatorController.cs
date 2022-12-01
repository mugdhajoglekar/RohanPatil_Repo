using Microsoft.AspNetCore.Mvc;
using WebCalculatorCore.Models;
using LibraryCalculator;

namespace WebCalculatorCore.Controllers
{
    public class CalculatorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(CalculatorCore c,string calculate)
        {
            Operations operations = new Operations();
            if (calculate == "+")
            {
                c.Result = operations.Add(c.Num1, c.Num2);

            }
            else if (calculate == "-")
            {
                c.Result = operations.Sub(c.Num1, c.Num2);
            }
            else if (calculate == "*")
            {
                c.Result = operations.Mul(c.Num1, c.Num2);
            }
            else if (calculate == "/")
            {
                c.Result = operations.Div(c.Num1, c.Num2);
            }
            ViewData["Result"] = c.Result;
            return View();
        }
    }
}
