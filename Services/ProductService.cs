using AutoMapper;
using SportsOrderApp.DTOs;
using SportsOrderApp.Models;
using SportsOrderApp.Repositories;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public class ProductService : IProductService
    {
        private readonly IMapper _mapper;
        private readonly IProductRepository _productRepository;

        public ProductService(IMapper mapper, IProductRepository productRepository)
        {
            _mapper = mapper;
            _productRepository = productRepository;
        }

        public IList<ProductModel> GetProductBySubCateId(long id)
        {
            var category = _productRepository.FindBy(x => x.SubCategoryId == id
                                    && x.Active == true && x.Deleted == false
                                    ).ToList();
            return _mapper.Map<List<ProductModel>>(category);
        }

    }
}
