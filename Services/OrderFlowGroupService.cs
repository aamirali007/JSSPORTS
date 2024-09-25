using SportsOrderApp.Models;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public class OrderFlowGroupService : IOrderFlowGroupService
    {
        private readonly IOrderFlowGroupRepository _orderFlowGroupRepository;

        public OrderFlowGroupService(IOrderFlowGroupRepository orderFlowGroupRepository)
        {
            _orderFlowGroupRepository = orderFlowGroupRepository;
        }

        //public async Task<OrderFlowGroup> GetByIdAsync(int id) => await _orderFlowGroupRepository.GetByIdAsync(id);

        //public async Task<IEnumerable<OrderFlowGroup>> GetAllAsync() => await _orderFlowGroupRepository.GetAllAsync();

        //public async Task AddAsync(OrderFlowGroup orderFlowGroup)
        //{
        //    await _orderFlowGroupRepository.AddAsync(orderFlowGroup);
        //    //await _orderFlowGroupRepository.SaveChangesAsync();
        //}

        //public async Task UpdateAsync(OrderFlowGroup orderFlowGroup)
        //{
        //    await _orderFlowGroupRepository.UpdateAsync(orderFlowGroup);
        //    //await _orderFlowGroupRepository.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    await _orderFlowGroupRepository.DeleteAsync(id);
        //    //await _orderFlowGroupRepository.SaveChangesAsync();
        //}
    }
}
