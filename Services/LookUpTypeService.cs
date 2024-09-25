using SportsOrderApp.Models;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public class LookUpTypeService : ILookUpTypeService
    {
        private readonly ILookUpTypeRepository _lookUpTypeRepository;

        public LookUpTypeService(ILookUpTypeRepository lookUpTypeRepository)
        {
            _lookUpTypeRepository = lookUpTypeRepository;
        }

        //public async Task<LookUpType> GetByIdAsync(int id) => await _lookUpTypeRepository.GetByIdAsync(id);

        //public async Task<IEnumerable<LookUpType>> GetAllAsync() => await _lookUpTypeRepository.GetAllAsync();

        //public async Task AddAsync(LookUpType lookUpType)
        //{
        //    await _lookUpTypeRepository.AddAsync(lookUpType);
        //    //await _lookUpTypeRepository.SaveChangesAsync();
        //}

        //public async Task UpdateAsync(LookUpType lookUpType)
        //{
        //    await _lookUpTypeRepository.UpdateAsync(lookUpType);
        //    //await _lookUpTypeRepository.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    await _lookUpTypeRepository.DeleteAsync(id);
        //    //await _lookUpTypeRepository.SaveChangesAsync();
        //}
    }
}
