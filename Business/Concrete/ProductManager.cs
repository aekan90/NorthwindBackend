using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public Sonuc<bool> Add(Product product)
        {
            try
            {
                // Örnek iş kuralı
                if (product.ProductID > 0)
                {
                    _productDal.Add(product);
                    return new Sonuc<bool>(true, Messages.ProductAdded);
                }
                else
                {
                    return new Sonuc<bool>(false, Messages.ErrorMessage);
                }
            }
            catch (Exception ex)
            {
                return new Sonuc<bool>(false, Messages.ErrorMessage + ex.Message);
            }
        }


        public Sonuc<bool> Delete(Product product)
        {
            try
            {
                _productDal.Delete(product);
                return new Sonuc<bool>(true, Messages.ProductDeleted, true);
            }
            catch (Exception ex)
            {
                return new Sonuc<bool>(true, Messages.ErrorMessage + ex.Message);
            }
        }

        public Sonuc<Product> GetById(int productId)
        {
            try
            {
                Product data = _productDal.Get(filter: p => p.ProductID == productId);
                return new Sonuc<Product>(true, Messages.SuccessMessage, data);
            }
            catch (Exception ex)
            {
                return new Sonuc<Product>(false, Messages.ErrorMessage + ex.Message);
            }

        }


        public Sonuc<List<Product>> GetList()
        {
            try
            {
                List<Product> data = _productDal.GetList().ToList();
                return new Sonuc<List<Product>>(true, Messages.SuccessMessage, data);
            }
            catch (Exception ex)
            {
                return new Sonuc<List<Product>>(false, Messages.ErrorMessage + ex.Message, null);
            }
        }


        public Sonuc<List<Product>> GetListByCategory(int categoryId)
        {
            try
            {
                List<Product> data = _productDal.GetList(filter: p => p.CategoryID == categoryId).ToList();
                return new Sonuc<List<Product>>(true, Messages.SuccessMessage, data);
            }
            catch (Exception ex)
            {
                // Hata durumunda:
                return new Sonuc<List<Product>>(false, Messages.ErrorMessage + ex.Message, null);
            }
        }

        public Sonuc<bool> Update(Product product)
        {
            try
            {
                _productDal.Update(product);
                return new Sonuc<bool>(true, Messages.SuccessMessage);
            }
            catch (Exception ex)
            {
                // Hata durumunda:
                return new Sonuc<bool>(false, Messages.ErrorMessage + ex.Message);
            }
        }

    }
}
