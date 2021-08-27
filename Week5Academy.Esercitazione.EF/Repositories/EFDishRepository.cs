using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Week5Academy.Esercitazione.Core.Interfaces;
using Week5Academy.Esercitazione.Core.Models;

namespace Week5Academy.Esercitazione.EF.Repositories
{
    public class EFDishRepository : IDishRepository
    {
        private readonly DishContext ctx;
        public EFDishRepository(DishContext dishCtx)
        {
            this.ctx = dishCtx;
        }
        public bool AddItem(Dish item)
        {
            if(item ==null)
            {
                throw new ArgumentNullException("invalid item");
            }

            ctx.Dishes.Add(item);
            ctx.SaveChanges();
            return true;
        }

        public bool DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public bool EditItem(Dish item)
        {
            if (item == null)
            {
                throw new ArgumentNullException("invalid item");
            }

            ctx.Entry<Dish>(item).State = EntityState.Modified;
            ctx.SaveChanges();
            return true;
        }

        public List<Dish> FetchAll()
        {
            return ctx.Dishes.ToList();
        }

        public Dish GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
