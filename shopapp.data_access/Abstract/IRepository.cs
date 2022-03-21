using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.data_access.Abstract
{
    public interface IRepository<T>
    {
        T GetById(int id); //geriye Product dondurur.

        List<T> GetAll(); //veritabanindaki butun product'lari getirir.

        void Create(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}
