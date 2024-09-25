using SportsOrderApp.Entities;
using SportsOrderApp.Models;

namespace SportsOrderApp.Repositories
{
    public interface IRepositories
    {
        

        public interface ICategoryRepository : IRepository<JsTblCategory> { }
        public interface IMainCategoryRepository : IRepository<JsTblMainCategory> { }
        public interface ISubCategoryRepository : IRepository<JsTblSubCategory> { }
        public interface IProductRepository : IRepository<JsTblProduct> { }
        public interface IFabricTypeRepository : IRepository<JsTblFabricType> { }
        public interface INeckStyleRepository : IRepository<JsTblNeckStyle> { }
        public interface IUserRepository : IRepository<JsTblUser> { }
        public interface IProductSizeListRepository : IRepository<JsTblProductSizeList> { }
        public interface IMockupRepository : IRepository<JsTblMockup> { }
        public interface IMockupAttachmentRepository : IRepository<JsTblMockupAttachment> { }
        #region Mockup Design Steps User Rights
        public interface IMockupDesignStepsNameRepository : IRepository<JsTblMockupDesignStepsName> { }
        public interface IMockupDesignStepRepository : IRepository<JsTblMockupDesignStep> { }
        public interface IMockupDesignStepUserRightRepository : IRepository<JsTblMockupDesignStepUserRight> { }
        #endregion
        public interface ICityRepository : IRepository<Entities.City> { }
        public interface IClientAccountRepository : IRepository<ClientAccount> { }

        public interface IClientRoleRepository : IRepository<ClientRole> { }

        public interface IClientRolePermissionRepository : IRepository<ClientRolePermission> { }

        public interface ICommentRepository : IRepository<Comment> { }

        public interface ICountryRepository : IRepository<Entities.Country> { }

        

        public interface IFlowStepNameRepository : IRepository<FlowStepName> { }

        public interface IGRNRepository : IRepository<GRN> { }

        public interface IItemRepository : IRepository<Item> { }

        public interface IItemAdjustmentRepository : IRepository<ItemAdjustment> { }

        public interface IItemCategoryRepository : IRepository<ItemCategory> { }

        public interface ILookUpTypeRepository : IRepository<LookUpType> { }

        public interface ILookUpValueRepository : IRepository<LookUpValue> { }

        public interface IMockOrderClientAttachmentRepository : IRepository<MockOrderClientAttachment> { }

        public interface IMockOrderDesignAttachmentRepository : IRepository<MockOrderDesignAttachment> { }

        public interface IMockOrderRequestRepository : IRepository<MockOrderRequest> { }

        

        public interface IOrderFlowGroupRepository : IRepository<OrderFlowGroup> { }

        public interface IPriceListRepository : IRepository<PriceList> { }
    }
}
