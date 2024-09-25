using SportsOrderApp.DTOs;
using SportsOrderApp.Models;

namespace SportsOrderApp.Services
{
    public interface INeckStyleService
    {
        public IList<NeckStyleModel> GetNeckStyle();
        //Task<NeckStyle> GetByIdAsync(int id);
        //Task<IEnumerable<NeckStyle>> GetAllAsync();
        //Task AddAsync(NeckStyle neckStyle);
        //Task UpdateAsync(NeckStyle neckStyle);
        //Task DeleteAsync(int id);
    }
}
