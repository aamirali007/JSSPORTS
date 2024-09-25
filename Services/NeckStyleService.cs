using AutoMapper;
using SportsOrderApp.DTOs;
using SportsOrderApp.Models;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public class NeckStyleService : INeckStyleService
    {
        private readonly IMapper _mapper;
        private readonly INeckStyleRepository _neckStyleRepository;

        public NeckStyleService(IMapper mapper, INeckStyleRepository neckStyleRepository)
        {
            _mapper = mapper;
            _neckStyleRepository = neckStyleRepository;
        }

        public IList<NeckStyleModel> GetNeckStyle()
        {
            var neck = _neckStyleRepository.GetAll().ToList();
            return _mapper.Map<List<NeckStyleModel>>((neck));
        }

        //public async Task<NeckStyle> GetByIdAsync(int id) => await _neckStyleRepository.GetByIdAsync(id);

        //public async Task<IEnumerable<NeckStyle>> GetAllAsync() => await _neckStyleRepository.GetAllAsync();

        //public async Task AddAsync(NeckStyle neckStyle)
        //{
        //    await _neckStyleRepository.AddAsync(neckStyle);
        //    //await _neckStyleRepository.SaveChangesAsync();
        //}

        //public async Task UpdateAsync(NeckStyle neckStyle)
        //{
        //    await _neckStyleRepository.UpdateAsync(neckStyle);
        //    //await _neckStyleRepository.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    await _neckStyleRepository.DeleteAsync(id);
        //    //await _neckStyleRepository.SaveChangesAsync();
        //}
    }
}
