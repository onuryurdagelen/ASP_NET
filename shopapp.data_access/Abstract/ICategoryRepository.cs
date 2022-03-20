﻿using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.data_access.Concrete
{
    public interface ICategoryRepository
    {
        Category GetById(int id); //geriye Product dondurur.

        List<Category> GetAll(); //veritabanindaki butun product'lari getirir.

        void Create(Product entity);

        void Update(Product entity);

        void Delete(int id);
    }
}
