using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Car_Dealership.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Car_Dealership.Controllers
{
    public class CarController : Controller
    {
        // GET: /<controller>/
        public async Task<IActionResult> Index()
        {
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44355/");

            var response = await client.GetAsync("api/car");
            var result = await response.Content.ReadAsAsync<List<Car>>();
            return View(result);
        }
        
        public IActionResult Result()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Search(string userInput)
        { 
            var client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44355/");
            var response = await client.GetAsync("api/car");
            var result = await response.Content.ReadAsAsync<List<Car>>();
            foreach (var car in result)
            {
                if (car.Make.ToLower() == userInput.ToLower() || car.Model.ToLower() == userInput.ToLower()
                    || car.Color.ToLower() == userInput.ToLower() || car.Year.ToString() == userInput)
                {
                return View("Result", car);
                   

                }
            }
            return View("Index");
        }
    }
}
