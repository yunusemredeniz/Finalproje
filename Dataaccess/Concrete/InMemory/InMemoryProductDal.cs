using Dataaccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Dataaccess.Concrete.InMemory
{
    public class InMemoryProductDal : IProductDal
    {
        List<Product> _products;
        public InMemoryProductDal()
        {
            _products = new List<Product> { new Product { ProductId=1,CategoryId=1,ProductName="bardak",UnitsInStock=7,UnitPrice=50},
                                            new Product { ProductId=2,CategoryId=1,ProductName="gözlük",UnitsInStock=5,UnitPrice=30},
                                            new Product {  ProductId=3,CategoryId=2,ProductName="camera",UnitsInStock=9,UnitPrice=500},
                                            new Product {  ProductId=4,CategoryId=2,ProductName="telefon",UnitsInStock=25,UnitPrice=2000},
                                            new Product {  ProductId=5,CategoryId=2,ProductName="bilgisayar",UnitsInStock=50,UnitPrice=50}
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }

        public void Delete(Product product)
        {
            Product productdelete = _products.SingleOrDefault(  p=>p.ProductId==product. ProductId);//foreach p=>p lambda
            _products.Remove(productdelete);
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> Getall()
        {
            return _products;
        }

        public List<Product> Getall(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAllCategory(int category)
        {
            return _products.Where(p => p.CategoryId == category).ToList();
        }

        public void Update(Product product)
        {
            Product productupdate = _products.SingleOrDefault(p => p. ProductId == product. ProductId);
            productupdate.ProductName = product.ProductName;
            productupdate.CategoryId = product.CategoryId;
            productupdate.UnitsInStock = product.UnitsInStock;
            productupdate.UnitPrice = product.UnitPrice;
        }
    }
}
