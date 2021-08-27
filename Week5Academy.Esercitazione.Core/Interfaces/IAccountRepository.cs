using System;
using System.Collections.Generic;
using System.Text;
using Week5Academy.Esercitazione.Core.Models;

namespace Week5Academy.Esercitazione.Core.Interfaces
{
    public interface IAccountRepository : IRepository<Account>
    {
        Account GetByUsername(string username);
    }
}
