using SportsOrderApp.Repositories;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Core
{
    public static class RepositoryServiceExtensions
    {
        public static void AddRepositoryServices(this IServiceCollection services)
        {
            
            services.AddScoped<IMainCategoryRepository, MainCategoryRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<ISubCategoryRepository, SubCategoryRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IFabricTypeRepository, FabricTypeRepository>();
            services.AddScoped<INeckStyleRepository, NeckStyleRepository>();
            services.AddScoped<IUserRepository, UserRepository>();
            services.AddScoped<IProductSizeListRepository, ProductSizeListRepository>();

            services.AddScoped<IMockupRepository, MockupRepository>();
            services.AddScoped<IMockupAttachmentRepository, MockupAttachmentRepository>();

            #region Mockup Design Steps User Rights
            services.AddScoped<IMockupDesignStepsNameRepository, MockupDesignStepsNameRepository>();
            services.AddScoped<IMockupDesignStepRepository, MockupDesignStepRepository>();
            services.AddScoped<IMockupDesignStepUserRightRepository, MockupDesignStepUserRightRepository>();
            #endregion
            //services.AddScoped<ICityRepository, CityRepository>();
            //services.AddScoped<IClientAccountRepository, ClientAccountRepository>();
            //services.AddScoped<IClientRoleRepository, ClientRoleRepository>();
            //services.AddScoped<IClientRolePermissionRepository, ClientRolePermissionRepository>();
            //services.AddScoped<ICommentRepository, CommentRepository>();
            //services.AddScoped<ICountryRepository, CountryRepository>();
            //;
            //services.AddScoped<IFlowStepNameRepository, FlowStepNameRepository>();
            //services.AddScoped<IGRNRepository, GRNRepository>();
            //services.AddScoped<IItemRepository, ItemRepository>();
            //services.AddScoped<IItemAdjustmentRepository, ItemAdjustmentRepository>();
            //services.AddScoped<IItemCategoryRepository, ItemCategoryRepository>();
            //services.AddScoped<ILookUpTypeRepository, LookUpTypeRepository>();
            //services.AddScoped<ILookUpValueRepository, LookUpValueRepository>();
            //services.AddScoped<IMockOrderClientAttachmentRepository, MockOrderClientAttachmentRepository>();
            //services.AddScoped<IMockOrderDesignAttachmentRepository, MockOrderDesignAttachmentRepository>();
            //services.AddScoped<IMockOrderRequestRepository, MockOrderRequestRepository>();
            //;
            //services.AddScoped<IOrderFlowGroupRepository, OrderFlowGroupRepository>();
            //services.AddScoped<IPriceListRepository, PriceListRepository>();
        }
    }
}
