using SportsOrderApp.Models;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public class ItemService : IItemService
    {
        private readonly IItemRepository _itemRepository;

        public ItemService(IItemRepository itemRepository)
        {
            _itemRepository = itemRepository;
        }

        //public async Task<Item> GetByIdAsync(int id) => await _itemRepository.GetByIdAsync(id);

        //public async Task<IEnumerable<Item>> GetAllAsync() => await _itemRepository.GetAllAsync();

        //public async Task AddAsync(Item item)
        //{
        //    await _itemRepository.AddAsync(item);
        //    //await _itemRepository.SaveChangesAsync();
        //}

        //public async Task UpdateAsync(Item item)
        //{
        //    await _itemRepository.UpdateAsync(item);
        //    //await _itemRepository.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    await _itemRepository.DeleteAsync(id);
        //    //await _itemRepository.SaveChangesAsync();
        //}
    }
}
