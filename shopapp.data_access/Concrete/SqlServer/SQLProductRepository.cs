﻿using shopapp.data_access.Abstract;
using shopapp.entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.data_access.Concrete.SqlServer
{
    class SQLProductRepository : IProductRepository
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}