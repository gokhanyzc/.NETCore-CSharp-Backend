#region

using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework.Contexts;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

#endregion

namespace DataAccess.Concrete.EntityFramework
{
    public  class EFProductDal : EfEntityRepositoryBase<Product,NorthwindContext>, IProductDal
    { 
    }
}
