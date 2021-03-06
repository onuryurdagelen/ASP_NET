using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.data_access.Abstract
{
    public interface IProductRepository:IRepository<Product>
    {
        List<Product> GetPopularProducts();
        List<Product> GetTop5Products();
    }
}
