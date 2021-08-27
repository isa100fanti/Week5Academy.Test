using System;
using System.Collections.Generic;
using System.Text;
using Week5Academy.Esercitazione.Core.Interfaces;
using Week5Academy.Esercitazione.Core.Models;

namespace Week5Academy.Esercitazione.Core.BusinessLayer
{
    public class MainBL : IBusinessLayer
    {
        private readonly IDishRepository dishRepo;
        private readonly IAccountRepository accRepo;

        public MainBL(IDishRepository dishRepository, IAccountRepository accountRepository) 
        {
            this.dishRepo = dishRepository;
            this.accRepo = accountRepository;
        }

        public DishResult AddDish(Dish newDish)
        {
            if (newDish == null)
            {
                throw new ArgumentNullException("Invalid item");
            }


            var result = dishRepo.AddItem(newDish);
            if(result)
            {
                return new DishResult
                {
                    Success = true,
                    Message = "ok"
                };
                
            }
            return new DishResult
            {
                Success = false,
                Message = $"cant create dish named {newDish.Name}"

            };
        }

        public DishResult DeleteDish(Dish deleteDish)
        {
            if (deleteDish == null)
            {
                throw new ArgumentNullException("Invalid item");
            }


            var result = dishRepo.DeleteItem(deleteDish.Id);
            if (result)
            {
                return new DishResult
                {
                    Success = true,
                    Message = "ok"
                };

            }
            return new DishResult
            {
                Success = false,
                Message = $"cant delete dish named {deleteDish.Name}"

            };
        }

        public DishResult EditDish(Dish editDish)
        {
            if (editDish == null)
            {
                throw new ArgumentNullException("Invalid item");
            }


            var result = dishRepo.EditItem(editDish);
            if (result)
            {
                return new DishResult
                {
                    Success = true,
                    Message = "ok"
                };

            }
            return new DishResult
            {
                Success = false,
                Message = $"cant edit dish named {editDish.Name}"

            };
        }

        public Account GetAccount(string username)
        {
            if(String.IsNullOrEmpty(username))
            {
                throw new ArgumentNullException("invalid username");
            }
            return accRepo.GetByUsername(username);
        }

        public Dish GetDishById(int id)
        {
            if (id <= 0)
            {
                throw new ArgumentException("Invalid id");
            }
            return dishRepo.GetById(id);
        }

        public IEnumerable<Dish> GetDishes()
        {
            return dishRepo.FetchAll();
        }
    }
}
