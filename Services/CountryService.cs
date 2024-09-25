using SportsOrderApp.Models;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public class CountryService : ICountryService
    {
        private readonly ICountryRepository _countryRepository;

        public CountryService(ICountryRepository countryRepository)
        {
            _countryRepository = countryRepository;
        }

        //public async Task<Country> GetByIdAsync(int id) => await _countryRepository.GetByIdAsync(id);

        //public async Task<IEnumerable<Country>> GetAllAsync() => await _countryRepository.GetAllAsync();

        //public async Task AddAsync(Country country)
        //{
        //    await _countryRepository.AddAsync(country);
        //    //await _countryRepository.SaveChangesAsync();
        //}

        //public async Task UpdateAsync(Country country)
        //{
        //    await _countryRepository.UpdateAsync(country);
        //    //await _countryRepository.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    await _countryRepository.DeleteAsync(id);
        //    //await _countryRepository.SaveChangesAsync();
        //}
    }

}
