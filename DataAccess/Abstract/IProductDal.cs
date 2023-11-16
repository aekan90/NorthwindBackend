using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
        // ürüne ait özel kodlar burada yazılacak o yüzden generic yapmayacağız.
        List<ListByCategory> GetListByCategory();
    }
}
