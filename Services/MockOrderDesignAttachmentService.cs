using SportsOrderApp.Models;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public class MockOrderDesignAttachmentService : IMockOrderDesignAttachmentService
    {
        private readonly IMockOrderDesignAttachmentRepository _mockOrderDesignAttachmentRepository;

        public MockOrderDesignAttachmentService(IMockOrderDesignAttachmentRepository mockOrderDesignAttachmentRepository)
        {
            _mockOrderDesignAttachmentRepository = mockOrderDesignAttachmentRepository;
        }

        //public async Task<MockOrderDesignAttachment> GetByIdAsync(int id) => await _mockOrderDesignAttachmentRepository.GetByIdAsync(id);

        //public async Task<IEnumerable<MockOrderDesignAttachment>> GetAllAsync() => await _mockOrderDesignAttachmentRepository.GetAllAsync();

        //public async Task AddAsync(MockOrderDesignAttachment mockOrderDesignAttachment)
        //{
        //    await _mockOrderDesignAttachmentRepository.AddAsync(mockOrderDesignAttachment);
        //    //await _mockOrderDesignAttachmentRepository.SaveChangesAsync();
        //}

        //public async Task UpdateAsync(MockOrderDesignAttachment mockOrderDesignAttachment)
        //{
        //    await _mockOrderDesignAttachmentRepository.UpdateAsync(mockOrderDesignAttachment);
        //    //await _mockOrderDesignAttachmentRepository.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    await _mockOrderDesignAttachmentRepository.DeleteAsync(id);
        //    //await _mockOrderDesignAttachmentRepository.SaveChangesAsync();
        //}
    }

}
