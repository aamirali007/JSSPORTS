using SportsOrderApp.DTOs;
using SportsOrderApp.Models;

namespace SportsOrderApp.Services
{
    public interface IProductService
    {
        public IList<ProductModel> GetProductBySubCateId(long id);
    }
}
