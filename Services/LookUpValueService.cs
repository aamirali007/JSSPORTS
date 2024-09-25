using SportsOrderApp.Models;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public class LookUpValueService : ILookUpValueService
    {
        private readonly ILookUpValueRepository _lookUpValueRepository;

        public LookUpValueService(ILookUpValueRepository lookUpValueRepository)
        {
            _lookUpValueRepository = lookUpValueRepository;
        }

        //public async Task<LookUpValue> GetByIdAsync(int id) => await _lookUpValueRepository.GetByIdAsync(id);

        //public async Task<IEnumerable<LookUpValue>> GetAllAsync() => await _lookUpValueRepository.GetAllAsync();

        //public async Task AddAsync(LookUpValue lookUpValue)
        //{
        //    await _lookUpValueRepository.AddAsync(lookUpValue);
        //    //await _lookUpValueRepository.SaveChangesAsync();
        //}

        //public async Task UpdateAsync(LookUpValue lookUpValue)
        //{
        //    await _lookUpValueRepository.UpdateAsync(lookUpValue);
        //    //await _lookUpValueRepository.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    await _lookUpValueRepository.DeleteAsync(id);
        //    //await _lookUpValueRepository.SaveChangesAsync();
        //}
    }

}
