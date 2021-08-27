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

        [Authorize(Policy = "AccountOwner")]
        public IActionResult Create()
        {
            
            return View();
        }

        [Authorize(Policy = "AccountOwner")]
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

        [Authorize(Policy = "AccountOwner")]
        public IActionResult Edit(int id)
        {
            if (id <= 0)
            {
                return View("Error", new ErrorViewModel());
            }

            //recupero l'impiegato da modificare
            var model = bl.GetDishById(id);
            
            var dishViewModel = new DishViewModel
            {
                
                Name = model.Name,
                Description = model.Description,
                Price = model.Price,
                //TypeCourse = TypeCourse
            };
            return View(dishViewModel);
        }

        [HttpPost]
        public IActionResult Edit(DishViewModel data)
        {
            if (data == null)
            {
                return View("Error", new ErrorViewModel());
            }
            if (ModelState.IsValid)
            {
                var result = bl.EditDish(new Dish
                {
                    Name = data.Name,
                    Description = data.Description,
                    Price = data.Price,
                    //TypeCourse = TypeCourse
                }
                );
                if (result.Success)
                {
                    return RedirectToAction("Index");
                }
            }

            return View();
        }

        [Authorize(Policy = "AccountOwner")]
        public IActionResult Delete(int id)
        {
            //... GUARDIA SULL'ID
            var model = bl.GetDishById(id);
            //guardia sul model
            return View(model);
        }

        [Authorize(Policy = "AccountOwner")]
        [HttpPost]
        public IActionResult Delete(Dish data)
        {
            var dishToDelete = bl.GetDishById(data.Id);

            var result = bl.DeleteDish(dishToDelete);
            if (result.Success)
            {
                return RedirectToAction("Index");
            }

            return View();
        }

    }
}
