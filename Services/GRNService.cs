using SportsOrderApp.Models;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public class GRNService : IGRNService
    {
        private readonly IGRNRepository _grnRepository;

        public GRNService(IGRNRepository grnRepository)
        {
            _grnRepository = grnRepository;
        }

        //public async Task<GRN> GetByIdAsync(int id) => await _grnRepository.GetByIdAsync(id);

        //public async Task<IEnumerable<GRN>> GetAllAsync() => await _grnRepository.GetAllAsync();

        //public async Task AddAsync(GRN grn)
        //{
        //    await _grnRepository.AddAsync(grn);
        //    //await _grnRepository.SaveChangesAsync();
        //}

        //public async Task UpdateAsync(GRN grn)
        //{
        //    await _grnRepository.UpdateAsync(grn);
        //    //await _grnRepository.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    await _grnRepository.DeleteAsync(id);
        //    //await _grnRepository.SaveChangesAsync();
        //}
    }
}
