using System;
using System.Collections.Generic;
using System.Text;

namespace Week5Academy.Esercitazione.Core.Interfaces
{
    public interface IRepository<T>
    {
        List<T> FetchAll();
        bool AddItem(T item);
        bool DeleteItem(int id);
        bool EditItem(T item);
        T GetById(int id);
    }
}
