using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        //Product Get(Expression<Func<Product, bool>> filter);
        //IList<Product> GetList(Expression<Func<Product, bool>> filter = null); 
        //void Add(Product entity);
        //void Update(Product entity);
        //void Delete(Product entity);
    }
}
