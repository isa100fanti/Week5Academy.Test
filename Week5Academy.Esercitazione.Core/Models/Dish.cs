using System;

namespace Week5Academy.Esercitazione.Core.Models
{
    public enum TypeCourse
    {
        MainCourse,
        SecondCourse,
        Dessert,
        Sides
    }
    public class Dish

    { 
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public TypeCourse TypeCourse { get; set; }
        public double Price { get; set; }

    }
}
