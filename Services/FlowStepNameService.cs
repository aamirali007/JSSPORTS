using SportsOrderApp.Models;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public class FlowStepNameService : IFlowStepNameService
    {
        private readonly IFlowStepNameRepository _flowStepNameRepository;

        public FlowStepNameService(IFlowStepNameRepository flowStepNameRepository)
        {
            _flowStepNameRepository = flowStepNameRepository;
        }

        //public async Task<FlowStepName> GetByIdAsync(int id) => await _flowStepNameRepository.GetByIdAsync(id);

        //public async Task<IEnumerable<FlowStepName>> GetAllAsync() => await _flowStepNameRepository.GetAllAsync();

        //public async Task AddAsync(FlowStepName flowStepName)
        //{
        //    await _flowStepNameRepository.AddAsync(flowStepName);
        //    //await _flowStepNameRepository.SaveChangesAsync();
        //}

        //public async Task UpdateAsync(FlowStepName flowStepName)
        //{
        //    await _flowStepNameRepository.UpdateAsync(flowStepName);
        //    //await _flowStepNameRepository.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    await _flowStepNameRepository.DeleteAsync(id);
        //    //await _flowStepNameRepository.SaveChangesAsync();
        //}
    }
}
