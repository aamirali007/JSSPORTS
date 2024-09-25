using SportsOrderApp.Services;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Core
{
    public static class ServiceExtensions
    {
        public static void AddServiceLayer(this IServiceCollection services)
        {
            
            services.AddScoped<IMainCategoryService, MainCategoryService>();
            services.AddScoped<ICategoryService, CategoryService>();
            services.AddScoped<ISubCategoryService, SubCategoryService>();
            services.AddScoped<IProductService, ProductService>();
            services.AddScoped<IFabricTypeService, FabricTypeService>();
            services.AddScoped<INeckStyleService, NeckStyleService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IProductSizeListService, ProductSizeListService>();

            services.AddScoped<IMockupService, MockupService>();
            services.AddScoped<IMockupAttachmentService, MockupAttachmentService>();

            // IUserMockupDesignRightsService
            services.AddScoped<IUserMockupDesignRightsService, UserMockupDesignRightsService>();
            //services.AddScoped<ICityService, CityService>();
            //services.AddScoped<IClientAccountService, ClientAccountService>();
            //services.AddScoped<IClientRolePermissionService, ClientRolePermissionService>();
            //services.AddScoped<IClientRoleService, ClientRoleService>();
            //services.AddScoped<ICommentService, CommentService>();
            //services.AddScoped<ICountryService, CountryService>();
            //
            //services.AddScoped<IFlowStepNameService, FlowStepNameService>();
            //services.AddScoped<IGRNService, GRNService>();
            //services.AddScoped<IItemAdjustmentService, ItemAdjustmentService>();
            //services.AddScoped<IItemCategoryService, ItemCategoryService>();
            //services.AddScoped<IItemService, ItemService>();
            //services.AddScoped<ILookUpTypeService, LookUpTypeService>();
            //services.AddScoped<ILookUpValueService, LookUpValueService>();
            //services.AddScoped<IMockOrderClientAttachmentService, MockOrderClientAttachmentService>();
            //services.AddScoped<IMockOrderDesignAttachmentService, MockOrderDesignAttachmentService>();
            //services.AddScoped<IMockOrderRequestService, MockOrderRequestService>();
            //
            //services.AddScoped<IOrderFlowGroupService, OrderFlowGroupService>();
            //services.AddScoped<IPriceListService, PriceListService>();
            //

        }
    }
}
