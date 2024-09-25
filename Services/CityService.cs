using SportsOrderApp.Models;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public class CityService : ICityService
    {
        private readonly ICityRepository _cityRepository;

        public CityService(ICityRepository cityRepository)
        {
            _cityRepository = cityRepository;
        }

        //public async Task<City> GetByIdAsync(int id) => await _cityRepository.GetByIdAsync(id);

        //public async Task<IEnumerable<City>> GetAllAsync() => await _cityRepository.GetAllAsync();

        //public async Task AddAsync(City city)
        //{
        //    await _cityRepository.AddAsync(city);
        //    // await _cityRepository.SaveChangesAsync();
        //}

        //public async Task UpdateAsync(City city)
        //{
        //    await _cityRepository.UpdateAsync(city);
        //    //await _cityRepository.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    await _cityRepository.DeleteAsync(id);
        //    // await _cityRepository.SaveChangesAsync();
        //}
    }
}
