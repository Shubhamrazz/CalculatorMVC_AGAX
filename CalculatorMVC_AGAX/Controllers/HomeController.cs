using CalculatorMVC_AGAX.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace CalculatorMVC_AGAX.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

       //public string CurrentDateTime()
       // {
       //     return DateTime.Today.ToString();
       // }
        public IActionResult Privacy()
        {
            return View();
        }
       
        [HttpPost]
        public CalculateModel Calculate(int number1, int number2)
        {
            CalculateModel numbers = new CalculateModel();
            numbers.Add = number1 + number2;
            numbers.Substract = number1 - number2;
            numbers.Multiply = number1 * number2;
            numbers.Divide = (decimal)number1 / number2;

            return numbers;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
