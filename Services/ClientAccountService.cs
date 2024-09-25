using SportsOrderApp.Models;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public class ClientAccountService : IClientAccountService
    {
        private readonly IClientAccountRepository _clientAccountRepository;

        public ClientAccountService(IClientAccountRepository clientAccountRepository)
        {
            _clientAccountRepository = clientAccountRepository;
        }

        //public async Task<ClientAccount> GetByIdAsync(int id) => await _clientAccountRepository.GetByIdAsync(id);

        //public async Task<IEnumerable<ClientAccount>> GetAllAsync() => await _clientAccountRepository.GetAllAsync();

        //public async Task AddAsync(ClientAccount clientAccount)
        //{
        //    await _clientAccountRepository.AddAsync(clientAccount);
        //    //await _clientAccountRepository.SaveChangesAsync();
        //}

        //public async Task UpdateAsync(ClientAccount clientAccount)
        //{
        //    await _clientAccountRepository.UpdateAsync(clientAccount);
        //    //await _clientAccountRepository.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    await _clientAccountRepository.DeleteAsync(id);
        //    //await _clientAccountRepository.SaveChangesAsync();
        //}
    }
}
