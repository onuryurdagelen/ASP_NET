using Microsoft.EntityFrameworkCore;
using shopapp.data_access.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace shopapp.data_access.Concrete.EfCore
{
    public class EfCoreGenericRepository<TEntity, TContext> : IRepository<TEntity>
        where TEntity : class //TEntity class olacaktir.
        where TContext : DbContext, new()   //==> new() instance olusturulabilir demektir.
    {
        public void Create(TEntity entity)
        {
            using(var context = new TContext())
            {
                context.Set<TEntity>().Add(entity); //context basta calisacagimiz Entity'i bulamaz.Bu nedenle Set methodunun icine TEntity yazarak ilgili Entity'e ulasiriz.
                                                    //(Products,Categories,Orders)
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using(var context = new TContext())
            {
                context.Set<TEntity>().Remove(entity);
                context.SaveChanges();
            }
        }

        public List<TEntity> GetAll()
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().ToList();
                
            }
        }

        public TEntity GetById(int id)
        {
            using(var context = new TContext())
            {
                return context.Set<TEntity>().Find(id);
            }
        }

        public void Update(TEntity entity)
        {
           using(var context = new TContext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
