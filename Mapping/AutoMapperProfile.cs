using AutoMapper;
using Microsoft.AspNetCore.Mvc.Rendering;
using SportsOrderApp.DTOs;
using SportsOrderApp.Entities;

namespace SportsOrderApp.Mapping
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile() 

        {
            CreateMap<JsTblMainCategory, MainCategoryModel>();
            CreateMap<MainCategoryAddModel, JsTblMainCategory>();

            CreateMap<JsTblCategory, CategoryModel>();
            CreateMap<CategoryAddModel, JsTblCategory>();

            CreateMap<JsTblSubCategory, SubCategoryModel>();
            CreateMap<SubCategoryAddModel, JsTblSubCategory>();

            CreateMap<JsTblProduct, ProductModel>();
            CreateMap<JsTblFabricType, FabricTypeModel>();
            CreateMap<JsTblNeckStyle, NeckStyleModel>();
            CreateMap<JsTblUser, UserListModel>();
            CreateMap<JsTblUser, UserModel>();
            CreateMap<RegisterModel, JsTblUser> ();
            CreateMap<JsTblProductSizeList, ProductSizeListModel>();

            CreateMap<JsTblMockupDesignStepsName, MockupDesignStepsNameModel>();
            CreateMap<JsTblMockupDesignStep, MockupDesignStepsModel>();
            CreateMap<JsTblMockupDesignStepUserRight, MockupDesignStepsUserRightsModel>();
            CreateMap<JsTblMockup, MockupModel>();
            CreateMap<JsTblMockup, ApprovedMockupModel>();
        }
    }
}
