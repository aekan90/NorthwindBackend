using Entities.Concrete;

namespace Business.Abstract
{
    public interface IProductService
    {
        Product GetById(int ProductId);
        List<Product> GetList();
        List<Product> GetListByCategory(int categoryId);
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);

    }
}
