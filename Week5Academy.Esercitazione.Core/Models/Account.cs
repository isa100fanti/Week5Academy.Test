using System;
using System.Collections.Generic;
using System.Text;

namespace Week5Academy.Esercitazione.Core.Models
{
    public enum Role
    {
        Client,
        Owner
    }
    public class Account
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string ReturnUrl { get; set; }
        public Role Role { get; set; }
    }
}
