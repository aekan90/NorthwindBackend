using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        Sonuc<Product> GetById(int ProductId);
        Sonuc<List<Product>> GetList();
        Sonuc<List<Product>> GetListByCategory(int categoryId);
        Sonuc<bool> Add(Product product);
        Sonuc<bool> Delete(Product product);
        Sonuc<bool> Update(Product product);
    }
}
