using AutoMapper;
using SportsOrderApp.DTOs;
using SportsOrderApp.Models;
using SportsOrderApp.Repositories;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public class FabricTypeService : IFabricTypeService
    {
        private readonly IMapper _mapper;
        private readonly IFabricTypeRepository _fabricTypeRepository;

        public FabricTypeService(IMapper mapper, IFabricTypeRepository fabricTypeRepository)
        {
            _mapper = mapper;
            _fabricTypeRepository = fabricTypeRepository;
        }

        public IList<FabricTypeModel> GetFabricTypes()
        {
            var category = _fabricTypeRepository.GetAll().ToList();
            return _mapper.Map<List<FabricTypeModel>>(category);
        }
        //public async Task<FabricType> GetByIdAsync(int id) => await _fabricTypeRepository.GetByIdAsync(id);

        //public async Task<IEnumerable<FabricType>> GetAllAsync() => await _fabricTypeRepository.GetAllAsync();

        //public async Task AddAsync(FabricType fabricType)
        //{
        //    await _fabricTypeRepository.AddAsync(fabricType);
        //    //await _fabricTypeRepository.SaveChangesAsync();
        //}

        //public async Task UpdateAsync(FabricType fabricType)
        //{
        //    await _fabricTypeRepository.UpdateAsync(fabricType);
        //    //await _fabricTypeRepository.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    await _fabricTypeRepository.DeleteAsync(id);
        //    //await _fabricTypeRepository.SaveChangesAsync();
        //}
    }
}
