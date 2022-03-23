
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.business.Concrete
{
    public interface IProductService
    {
        entity.Product GetById(int id); //geriye Product dondurur.

        List<entity.Product> GetAll(); //veritabanindaki butun product'lari getirir.

        void Create(entity.Product entity);

        void Update(entity.Product entity);

        void Delete(entity.Product entity);
    }
}
