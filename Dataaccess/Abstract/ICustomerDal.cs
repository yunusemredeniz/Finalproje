using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dataaccess.Abstract
{
    public interface ICustomerDal:IEntityRepository<Customer>
    {
    }
}
