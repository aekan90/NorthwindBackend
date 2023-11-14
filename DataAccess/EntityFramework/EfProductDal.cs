using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using DataAccess.EntityFramework.Context;
using Entities.Concrete;

namespace DataAccess.EntityFramework
{
    public class EfProductDal : Core.DataAccess.EntityFramework.EfEntityRepositoryBase<Product,NorthWindContext>, IProductDal
    {
    }
}
