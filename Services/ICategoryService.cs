using SportsOrderApp.DTOs;
using SportsOrderApp.Models;

namespace SportsOrderApp.Services
{
    public interface ICategoryService
    {
        public IList<CategoryModel> GetMainCategory();
        public IList<CategoryModel> GetMainCategoryByMainCategoryId(long mainCatId);
        public void AddCategory(CategoryAddModel model);
        //Task<Category> GetByIdAsync(int id);
        //Task<IEnumerable<Category>> GetAllAsync();
        //Task AddAsync(Category category);
        //Task UpdateAsync(Category category);
        //Task DeleteAsync(int id);
    }
}
