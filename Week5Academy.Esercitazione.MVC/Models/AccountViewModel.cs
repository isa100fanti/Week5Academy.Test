using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Week5Academy.Esercitazione.MVC.Models
{
    public class AccountViewModel
    {
        public int Id { get; set; }
        [Required, DisplayName("User"), DataType(DataType.EmailAddress)]
        public string Username { get; set; }
        [Required, DisplayName("Password"), DataType(DataType.Password)]

        public string Password { get; set; }
        public string ReturnUrl { get; set; }
        
    }
}
