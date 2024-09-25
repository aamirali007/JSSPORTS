using SportsOrderApp.Models;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public class ClientRolePermissionService : IClientRolePermissionService
    {
        private readonly IClientRolePermissionRepository _clientRolePermissionRepository;

        public ClientRolePermissionService(IClientRolePermissionRepository clientRolePermissionRepository)
        {
            _clientRolePermissionRepository = clientRolePermissionRepository;
        }

        //public async Task<ClientRolePermission> GetByIdAsync(int id) => await _clientRolePermissionRepository.GetByIdAsync(id);

        //public async Task<IEnumerable<ClientRolePermission>> GetAllAsync() => await _clientRolePermissionRepository.GetAllAsync();

        //public async Task AddAsync(ClientRolePermission clientRolePermission)
        //{
        //    await _clientRolePermissionRepository.AddAsync(clientRolePermission);
        //    //await _clientRolePermissionRepository.SaveChangesAsync();
        //}

        //public async Task UpdateAsync(ClientRolePermission clientRolePermission)
        //{
        //    await _clientRolePermissionRepository.UpdateAsync(clientRolePermission);
        //    //await _clientRolePermissionRepository.SaveChangesAsync();
        //}

        //public async Task DeleteAsync(int id)
        //{
        //    await _clientRolePermissionRepository.DeleteAsync(id);
        //    //await _clientRolePermissionRepository.SaveChangesAsync();
        //}
    }
}
