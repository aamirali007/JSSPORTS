using SportsOrderApp.Models;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public class ItemAdjustmentService : IItemAdjustmentService
    {
        private readonly IItemAdjustmentRepository _itemAdjustmentRepository;

        public ItemAdjustmentService(IItemAdjustmentRepository itemAdjustmentRepository)
        {
            _itemAdjustmentRepository = itemAdjustmentRepository;
        }

        //public async Task<ItemAdjustment> GetByIdAsync(int id) => await _itemAdjustmentRepository.GetByIdAsync(id);

        //public async Task<IEnumerable<ItemAdjustment>> GetAllAsync() => await _itemAdjustmentRepository.GetAllAsync();

        //public async Task AddAsync(ItemAdjustment itemAdjustment)
        //{
        //    await _itemAdjustmentRepository.AddAsync(itemAdjustment);
        //    //await _itemAdjustmentRepository.SaveChangesAsync();
        //}

        //public async Task UpdateAsync(ItemAdjustment itemAdjustment)
        //{
        //    await _itemAdjustmentRepository.UpdateAsync(itemAdjustment);
        //    //await _itemAdjustmentRepository.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    await _itemAdjustmentRepository.DeleteAsync(id);
        //    //await _itemAdjustmentRepository.SaveChangesAsync();
        //}
    }
}
