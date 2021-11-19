using Dataaccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Dataaccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public void Add(Product entity)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                var eklendi = context.Entry(entity); //referans yakala
                eklendi.State = EntityState.Added;   //ekle
                context.SaveChanges();
            }
        }

        public void Delete(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var silindi= context.Entry(entity); //referans yakala
                silindi.State = EntityState.Deleted;   
                context.SaveChanges();
            }
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                return context.Set<Product>().SingleOrDefault(filter);
            }
        }

        public List<Product> Getall(Expression<Func<Product, bool>> filter = null)
        {
            using (NorthwindContext context=new NorthwindContext())
            {
                return filter==null?context.Set<Product>().ToList():context.Set<Product>().Where(filter).ToList();

            }
        }

        public void Update(Product entity)
        {
            using (NorthwindContext context = new NorthwindContext())
            {
                var guncellendi = context.Entry(entity); //referans yakala
                guncellendi.State = EntityState.Modified;   //ekle
                context.SaveChanges();
            }
        }
    }
}
