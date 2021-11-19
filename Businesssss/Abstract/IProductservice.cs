using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Businesssss.Abstract
{
    public interface IProductservice
    {
        List<Product> Getall();
        List<Product> GetAllByCategoryId(int id);
        List<Product> GetByUnitPrice(decimal min, decimal max);
    }
}
