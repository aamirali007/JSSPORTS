using SportsOrderApp.Models;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public class MockOrderRequestService : IMockOrderRequestService
    {
        private readonly IMockOrderRequestRepository _mockOrderRequestRepository;

        public MockOrderRequestService(IMockOrderRequestRepository mockOrderRequestRepository)
        {
            _mockOrderRequestRepository = mockOrderRequestRepository;
        }

        //public async Task<MockOrderRequest> GetByIdAsync(int id) => await _mockOrderRequestRepository.GetByIdAsync(id);

        //public async Task<IEnumerable<MockOrderRequest>> GetAllAsync() => await _mockOrderRequestRepository.GetAllAsync();

        //public async Task AddAsync(MockOrderRequest mockOrderRequest)
        //{
        //    await _mockOrderRequestRepository.AddAsync(mockOrderRequest);
        //    //await _mockOrderRequestRepository.SaveChangesAsync();
        //}

        //public async Task UpdateAsync(MockOrderRequest mockOrderRequest)
        //{
        //    await _mockOrderRequestRepository.UpdateAsync(mockOrderRequest);
        //    //await _mockOrderRequestRepository.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    await _mockOrderRequestRepository.DeleteAsync(id);
        //    //await _mockOrderRequestRepository.SaveChangesAsync();
        //}
    }
}
