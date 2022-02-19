#region

using Core.DataAccess;
using Entities.Concrete;

#endregion


namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
