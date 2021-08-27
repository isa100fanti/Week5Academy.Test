using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Week5Academy.Esercitazione.Core.Interfaces;
using Week5Academy.Esercitazione.Core.Models;
using Week5Academy.Esercitazione.MVC.Models;

namespace Week5Academy.Esercitazione.MVC.Controllers
{
    public class DishController : Controller
    {
        //dichiaro un istanza di IBL per collegarmi al core
        private readonly IBusinessLayer bl; //la inietto nel costruttore
        public DishController(IBusinessLayer businessLayer)
        {
            this.bl = businessLayer;
        }

        [Authorize]
        public IActionResult Index()
        {
            var model = bl.GetDishes();
            return View(model);
        }

        [Authorize(Policy = "Owner")]
        public IActionResult Create()
        {
            
            return View();
        }

        [Authorize(Policy = "Owner")]
        [HttpPost]
        public IActionResult Create(DishViewModel data)
        {
            if(data == null)
            {
                return View("Error", new ErrorViewModel());
            }

            var result = bl.AddDish(new Dish
            {
                Name = data.Name,
                Description = data.Description,
                Price = data.Price
                
            });
            return View(result);
        }


        public IActionResult Details(int id)
        {
            if(id <= 0)
            {
                return View("error", new ErrorViewModel());
            }

            var result = bl.GetDishById(id);

            return View(result);
        }



    }
}
