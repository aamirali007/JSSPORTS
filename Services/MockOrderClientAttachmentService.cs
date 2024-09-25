using SportsOrderApp.Models;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public class MockOrderClientAttachmentService : IMockOrderClientAttachmentService
    {
        private readonly IMockOrderClientAttachmentRepository _mockOrderClientAttachmentRepository;

        public MockOrderClientAttachmentService(IMockOrderClientAttachmentRepository mockOrderClientAttachmentRepository)
        {
            _mockOrderClientAttachmentRepository = mockOrderClientAttachmentRepository;
        }

        //public async Task<MockOrderClientAttachment> GetByIdAsync(int id) => await _mockOrderClientAttachmentRepository.GetByIdAsync(id);

        //public async Task<IEnumerable<MockOrderClientAttachment>> GetAllAsync() => await _mockOrderClientAttachmentRepository.GetAllAsync();

        //public async Task AddAsync(MockOrderClientAttachment mockOrderClientAttachment)
        //{
        //    await _mockOrderClientAttachmentRepository.AddAsync(mockOrderClientAttachment);
        //    //await _mockOrderClientAttachmentRepository.SaveChangesAsync();
        //}

        //public async Task UpdateAsync(MockOrderClientAttachment mockOrderClientAttachment)
        //{
        //    await _mockOrderClientAttachmentRepository.UpdateAsync(mockOrderClientAttachment);
        //    //await _mockOrderClientAttachmentRepository.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    await _mockOrderClientAttachmentRepository.DeleteAsync(id);
        //    //await _mockOrderClientAttachmentRepository.SaveChangesAsync();
        //}
    }
}
