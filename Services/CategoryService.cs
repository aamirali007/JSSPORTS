using AutoMapper;
using SportsOrderApp.DTOs;
using SportsOrderApp.Entities;
using SportsOrderApp.Models;
using SportsOrderApp.Repositories;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        private readonly IMapper _mapper;
        public CategoryService(IMapper mapper, ICategoryRepository categoryRepository)
        {
            _mapper = mapper;
            _categoryRepository = categoryRepository;
        }

        public IList<CategoryModel> GetMainCategory()
        {
            var category = _categoryRepository.GetAll();
            return _mapper.Map<List<CategoryModel>>(category);
        }
        public IList<CategoryModel> GetMainCategoryByMainCategoryId(long mainCatId)
        {
            var category = _categoryRepository.FindBy(x => x.MainCategoryId == mainCatId 
                                    && x.Active == true && x. Deleted == false
                                    ).ToList();
            return _mapper.Map<List<CategoryModel>>(category);
        }

        public void AddCategory(CategoryAddModel model)
        {
            if (model.CategoryId == 0)
            {
                var mainCat = new CategoryAddModel
                {
                    Name = model.Name,
                    Code = model.Code,
                    Description = model.Description,
                    MainCategoryId = model.MainCategoryId
                };

                var res = _mapper.Map<JsTblCategory>(mainCat);
                res.Active = true;
                res.Deleted = false;
                res.IsDefault = false;
                res.CreadtedBy = "AAMIR";
                res.CreatedDate = DateTime.Now;
                res.ModifiedDate = DateTime.Now;
                res.ModifiedBy = "AAMIR";
                _categoryRepository.Add(res);
                _categoryRepository.Commit();
            }
            else
            {

            }

        }


        //public async Task<Category> GetByIdAsync(int id) => await _categoryRepository.GetByIdAsync(id);

        //public async Task<IEnumerable<Category>> GetAllAsync() => await _categoryRepository.GetAllAsync();

        //public  Task AddAsync(Category category)
        //{
        //     _categoryRepository.Add(category);
        //    //await _categoryRepository.SaveChangesAsync();
        //}

        //public async Task UpdateAsync(Category category)
        //{
        //    await _categoryRepository.UpdateAsync(category);
        //    //await _categoryRepository.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    await _categoryRepository.DeleteAsync(id);
        //    //await _categoryRepository.SaveChangesAsync();
        //}
    }

}
