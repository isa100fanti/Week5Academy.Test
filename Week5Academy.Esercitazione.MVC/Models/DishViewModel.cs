using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Week5Academy.Esercitazione.MVC.Models
{
    public enum TypeCourse
    {
        MainCourse,
        SecondCourse,
        Dessert,
        Sides
    }
    public class DishViewModel
    {
        public int Id { get; set; }
        [Required, DisplayName("Name"), StringLength(20, MinimumLength =5)]
        public string Name { get; set; }
        [Required, DisplayName("Description"), StringLength(50, MinimumLength = 10)]

        public string Description { get; set; }
        public TypeCourse TypeCourse { get; set; }
        [Required, DisplayName("Price")]

        public double Price { get; set; }
    }
}
