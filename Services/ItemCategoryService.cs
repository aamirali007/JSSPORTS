using SportsOrderApp.Models;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public class ItemCategoryService : IItemCategoryService
    {
        private readonly IItemCategoryRepository _itemCategoryRepository;

        public ItemCategoryService(IItemCategoryRepository itemCategoryRepository)
        {
            _itemCategoryRepository = itemCategoryRepository;
        }

        //public async Task<ItemCategory> GetByIdAsync(int id) => await _itemCategoryRepository.GetByIdAsync(id);

        //public async Task<IEnumerable<ItemCategory>> GetAllAsync() => await _itemCategoryRepository.GetAllAsync();

        //public async Task AddAsync(ItemCategory itemCategory)
        //{
        //    await _itemCategoryRepository.AddAsync(itemCategory);
        //    //await _itemCategoryRepository.SaveChangesAsync();
        //}

        //public async Task UpdateAsync(ItemCategory itemCategory)
        //{
        //    await _itemCategoryRepository.UpdateAsync(itemCategory);
        //    //await _itemCategoryRepository.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    await _itemCategoryRepository.DeleteAsync(id);
        //    //await _itemCategoryRepository.SaveChangesAsync();
        //}
    }
}
