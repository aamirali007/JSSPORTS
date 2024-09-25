using AutoMapper;
using SportsOrderApp.DTOs;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public interface IProductSizeListService
    {
        public IList<ProductSizeListModel> GetProductSizes();
    }
    public class ProductSizeListService: IProductSizeListService
    {
        private readonly IMapper _mapper;
        private readonly IProductSizeListRepository _productSizeListRepository;
        public ProductSizeListService(
            IMapper mapper,
            IProductSizeListRepository productSizeListRepository
            ) 
        {
            _mapper = mapper;
            _productSizeListRepository = productSizeListRepository;
        }
        public IList<ProductSizeListModel> GetProductSizes()
        {
            var res = _productSizeListRepository.GetAll().ToList();
            return _mapper.Map<List<ProductSizeListModel>>( res );
        }
    }
}
