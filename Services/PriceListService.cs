using SportsOrderApp.Models;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public class PriceListService : IPriceListService
    {
        private readonly IPriceListRepository _priceListRepository;

        public PriceListService(IPriceListRepository priceListRepository)
        {
            _priceListRepository = priceListRepository;
        }

        //public async Task<PriceList> GetByIdAsync(int id) => await _priceListRepository.GetByIdAsync(id);

        //public async Task<IEnumerable<PriceList>> GetAllAsync() => await _priceListRepository.GetAllAsync();

        //public async Task AddAsync(PriceList priceList)
        //{
        //    await _priceListRepository.AddAsync(priceList);
        //    //await _priceListRepository.SaveChangesAsync();
        //}

        //public async Task UpdateAsync(PriceList priceList)
        //{
        //    await _priceListRepository.UpdateAsync(priceList);
        //    //await _priceListRepository.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    await _priceListRepository.DeleteAsync(id);
        //    //await _priceListRepository.SaveChangesAsync();
        //}
    }
}
