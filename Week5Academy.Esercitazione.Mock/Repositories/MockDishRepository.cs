using System;
using System.Collections.Generic;
using System.Linq;
using Week5Academy.Esercitazione.Core.Interfaces;
using Week5Academy.Esercitazione.Core.Models;

namespace Week5Academy.Esercitazione.Mock.Repositories
{
    public class MockDishRepository : IDishRepository
    {
        //faccio prima i test col mock
        private static List<Dish> dishes = new List<Dish>()
        {
            new Dish { Id = 1, Name = "spaghetti autunno" , Description = "spaghetti rossi con polpette", TypeCourse = TypeCourse.MainCourse ,Price = 12.2},
            new Dish { Id = 1, Name = "tagliata nostrana" , Description = "Tagliata ai ferri all'aceto balsamico", TypeCourse = TypeCourse.SecondCourse ,Price = 7.5}

        };

        public bool AddItem(Dish item)
        {
            if(item == null)
            {
                throw new ArgumentNullException("invalid item");
            }

            var lastid = FetchAll().Last().Id;
            item.Id = lastid+1;
            FetchAll().Add(item);
            return true;
        }

        public bool DeleteItem(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentNullException("invalid id");
            }

            var itemToDelete = GetById(id);
            FetchAll().Remove(itemToDelete);
            return true;
        }

        public bool EditItem(Dish item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("invalid item");
            }

            var oldItem = FetchAll().FirstOrDefault(a => a.Id == item.Id);
            FetchAll().Remove(oldItem);
            FetchAll().Add(item);


            return true;
        }

        public List<Dish> FetchAll()
        {
            return dishes;
        }

        public Dish GetById(int id)
        {
            if(id <=0)
            {
                throw new ArgumentException("invalid id");
            }

            return FetchAll().FirstOrDefault(a => a.Id == id);
        }
    }
}
