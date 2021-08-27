using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Week5Academy.Esercitazione.Core.Interfaces;
using Week5Academy.Esercitazione.Core.Models;

namespace Week5Academy.Esercitazione.Mock.Repositories
{
    public class MockAccountRepository : IAccountRepository
    {
        private static List<Account> accounts = new List<Account>() //mi serve una lista statica
        {
            new Account {Id = 1, Username = "isacento@abc.it", Password = "1234" , Role = Role.Client},
            new Account {Id = 2, Username = "ginos@venice.it", Password = "5678" , Role = Role.Owner}
        };
        public bool AddItem(Account item)
        {
            throw new NotImplementedException();
        }

        public bool DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public bool EditItem(Account item)
        {
            throw new NotImplementedException();
        }

        public List<Account> FetchAll()
        {
            return accounts;
        }

        public Account GetById(int id)
        {
            throw new NotImplementedException();
        }

        //per ora mi serve solo questo
        public Account GetByUsername(string username)
        {
            return accounts.FirstOrDefault(a => a.Username.Equals(username));
        }
    }
}
