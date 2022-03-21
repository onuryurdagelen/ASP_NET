using shopapp.data_access.Abstract;
using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.data_access.Concrete
{
    public interface ICategoryRepository:IRepository<Category>
    {
        List<Category> GetPopularCategories();
    }
}
