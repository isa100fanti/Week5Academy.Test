using System;
using System.Collections.Generic;
using System.Text;
using Week5Academy.Esercitazione.Core.Models;

namespace Week5Academy.Esercitazione.Core.Interfaces
{
    public interface IBusinessLayer
    {
        IEnumerable<Dish> GetDishes();
        Dish GetDishById(int id);
        DishResult EditDish(Dish editDish);
        DishResult DeleteDish(Dish deleteDish);
        DishResult AddDish(Dish newDish);

        //metterò anche i metodi di Account
        Account GetAccount(string username);

    }
}
