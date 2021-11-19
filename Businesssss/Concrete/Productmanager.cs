using Businesssss.Abstract;
using Dataaccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businesssss.Concrete
{
    public class Productmanager : IProductservice
    {
        IProductDal _productDal;

        public Productmanager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public List<Product> Getall()
        {
            return _productDal.Getall();
        }

        public List<Product> GetAllByCategoryId(int id)
        {
            return _productDal.Getall(p => p.CategoryId == id);
        }

        public List<Product> GetByUnitPrice(decimal min, decimal max)
        {
            return _productDal.Getall(p => p.UnitPrice >= min && p.UnitPrice <= max);
        }
    }
}
