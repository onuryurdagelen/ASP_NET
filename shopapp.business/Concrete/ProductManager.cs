using System;
using System.Collections.Generic;
using System.Text;

namespace shopapp.business.Concrete
{
    public class ProductManager : IProductService
    {
        private data_access.Abstract.IProductRepository _productRepository;
        //EfCoreProductRepository productRepository = new EfCoreProductRepository();

        public ProductManager(data_access.Abstract.IProductRepository productRepository)
        {
            _productRepository = productRepository; 
        }
        public void Create(entity.Product entity)
        {

            //is kurallari uygula
            _productRepository.Create(entity);
        }

        public void Delete(entity.Product entity)
        {
            //is kurallari uygula
            _productRepository.Delete(entity);
        }

        public List<entity.Product> GetAll()
        {
           return _productRepository.GetAll();
        }

        public entity.Product GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(entity.Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
