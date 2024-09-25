using AutoMapper;
using SportsOrderApp.DTOs;
using SportsOrderApp.Entities;
using SportsOrderApp.Models;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Services
{
    public interface IMainCategoryService
    {
        public IList<MainCategoryModel> GetMainCategory();
        public void AddMainCategory(MainCategoryAddModel model);
    }
    public class MainCategoryService : IMainCategoryService
    {
        private readonly IMainCategoryRepository _mainCategoryRepository;
        private readonly IMapper _mapper;
        public MainCategoryService(IMapper mapper, IMainCategoryRepository mainCategoryRepository) 
        {
            _mapper = mapper;
            _mainCategoryRepository = mainCategoryRepository;
        }

        public IList<MainCategoryModel> GetMainCategory()
        {
            var mainCateResult = _mainCategoryRepository.GetAll().ToList();

            return _mapper.Map<List<MainCategoryModel>>(mainCateResult);
        }

        public void AddMainCategory(MainCategoryAddModel model)
        {
            if (model.MainCategoryId == 0)
            {
                var mainCat = new MainCategoryAddModel
                {
                    Name = model.Name,
                    Code = model.Code,
                    Description = model.Description
                };

                var res = _mapper.Map<JsTblMainCategory>(mainCat);
                res.Active = true;
                res.Deleted = false;
                res.IsDefault = false;
                res.CreadtedBy = "AAMIR";
                res.CreatedDate = DateTime.Now;
                res.ModifiedDate = DateTime.Now;
                res.ModifiedBy = "AAMIR";
                _mainCategoryRepository.Add(res);
                _mainCategoryRepository.Commit();
            }
            else
            {

            }
           
        }
    }
}
