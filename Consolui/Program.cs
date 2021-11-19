using Businesssss.Concrete;
using Dataaccess.Concrete.EntityFramework;
using Dataaccess.Concrete.InMemory;
using System;

namespace Consolui
{
    class Program
    {
        static void Main(string[] args)
        { Productmanager productmanager = new Productmanager(new EfProductDal());
            foreach (var product in productmanager.GetByUnitPrice(50,100))
            {
                Console.WriteLine(product.ProductName);
            }
            
        }
    }
}
