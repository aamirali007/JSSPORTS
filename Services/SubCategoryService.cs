using AutoMapper;
using SportsOrderApp.DTOs;
using SportsOrderApp.Entities;
using SportsOrderApp.Repositories;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public interface ISubCategoryService
    {
        public IList<CategoryModel> GetSubCategory(); 
        public IList<SubCategoryModel> GetSubCategoryBySubCatId(long id);
        public void AddSubCategory(SubCategoryAddModel model);
    }
    public class SubCategoryService : ISubCategoryService
    {
        private readonly ISubCategoryRepository _subCategoryRepository;
        private readonly IMapper _mapper;
        public SubCategoryService(IMapper mapper, ISubCategoryRepository subCategoryRepository) 
        {
            _mapper = mapper;
            _subCategoryRepository = subCategoryRepository;
        }
        public IList<CategoryModel> GetSubCategory()
        {
            var category = _subCategoryRepository.GetAll();
            return _mapper.Map<List<CategoryModel>>(category);
        }
        public IList<SubCategoryModel> GetSubCategoryBySubCatId(long id)
        {
            var category = _subCategoryRepository.FindBy(x => x.CategoryId == id
                                    && x.Active == true && x.Deleted == false
                                    ).ToList();
            return _mapper.Map<List<SubCategoryModel>>(category);
        }
        public void AddSubCategory(SubCategoryAddModel model)
        {
            if (model.SubCategoryId == 0)
            {
                var mainCat = new SubCategoryAddModel
                {
                    Name = model.Name,
                    Code = model.Code,
                    Description = model.Description,
                    CategoryId = model.CategoryId
                };

                var res = _mapper.Map<JsTblSubCategory>(mainCat);
                res.Active = true;
                res.Deleted = false;
                res.IsDefault = false;
                res.CreatedBy = "AAMIR";
                res.CreatedDate = DateTime.Now;
                res.ModifiedDate = DateTime.Now;
                res.ModifiedBy = "AAMIR";
                _subCategoryRepository.Add(res);
                _subCategoryRepository.Commit();
            }
            else
            {

            }

        }
    }
}
