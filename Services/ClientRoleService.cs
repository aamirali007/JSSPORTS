using SportsOrderApp.Models;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public class ClientRoleService : IClientRoleService
    {
        private readonly IClientRoleRepository _clientRoleRepository;

        public ClientRoleService(IClientRoleRepository clientRoleRepository)
        {
            _clientRoleRepository = clientRoleRepository;
        }

        //public async Task<ClientRole> GetByIdAsync(int id) => await _clientRoleRepository.GetByIdAsync(id);

        //public async Task<IEnumerable<ClientRole>> GetAllAsync() => await _clientRoleRepository.GetAllAsync();

        //public async Task AddAsync(ClientRole clientRole)
        //{
        //    await _clientRoleRepository.AddAsync(clientRole);
        //    //await _clientRoleRepository.SaveChangesAsync();
        //}

        //public async Task UpdateAsync(ClientRole clientRole)
        //{
        //    await _clientRoleRepository.UpdateAsync(clientRole);
        //    //await _clientRoleRepository.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    await _clientRoleRepository.DeleteAsync(id);
        //    //await _clientRoleRepository.SaveChangesAsync();
        //}
    }
}
