using SportsOrderApp.DTOs;
using SportsOrderApp.Models;

namespace SportsOrderApp.Services
{
    public interface IFabricTypeService
    {
        public IList<FabricTypeModel> GetFabricTypes();
    }
}
