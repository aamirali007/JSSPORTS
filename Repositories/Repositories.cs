using Microsoft.EntityFrameworkCore;
using SportsOrderApp.Data;
using SportsOrderApp.Entities;
using SportsOrderApp.Models;
using static SportsOrderApp.Repositories.IRepositories;

namespace SportsOrderApp.Repositories
{
   

    public class CategoryRepository : Repository<JsTblCategory>, ICategoryRepository
    {
        public CategoryRepository(JSDBContext context) : base(context) { }
    }
    public class MainCategoryRepository : Repository<JsTblMainCategory>, IMainCategoryRepository
    {
        public MainCategoryRepository(JSDBContext context) : base(context) { }
    }
    public class SubCategoryRepository : Repository<JsTblSubCategory>, ISubCategoryRepository
    {
        public SubCategoryRepository(JSDBContext context) : base(context) { }
    }
    public class ProductRepository : Repository<JsTblProduct>, IProductRepository
    {
        public ProductRepository(JSDBContext context) : base(context) { }
    }
    public class UserRepository : Repository<JsTblUser>, IUserRepository
    {
        public UserRepository(JSDBContext context) : base(context) { }
    }

    public class ProductSizeListRepository : Repository<JsTblProductSizeList>, IProductSizeListRepository
    {
        public ProductSizeListRepository(JSDBContext context) : base(context) { }
    }

    public class MockupRepository : Repository<JsTblMockup>, IMockupRepository
    {
        public MockupRepository(JSDBContext context) : base(context) { }
    }

    public class MockupAttachmentRepository : Repository<JsTblMockupAttachment>, IMockupAttachmentRepository
    {
        public MockupAttachmentRepository(JSDBContext context) : base(context) { }
    }

    #region Mockup Design Steps User Rights
    public class MockupDesignStepsNameRepository : Repository<JsTblMockupDesignStepsName>, IMockupDesignStepsNameRepository
    {
        public MockupDesignStepsNameRepository(JSDBContext context) : base(context) { }
    }
    public class MockupDesignStepRepository : Repository<JsTblMockupDesignStep>, IMockupDesignStepRepository
    {
        public MockupDesignStepRepository(JSDBContext context) : base(context) { }
    }
    public class MockupDesignStepUserRightRepository : Repository<JsTblMockupDesignStepUserRight>, IMockupDesignStepUserRightRepository
    {
        public MockupDesignStepUserRightRepository(JSDBContext context) : base(context) { }
    }
    #endregion
    public class CityRepository : Repository<Entities.City>, ICityRepository
    {
        public CityRepository(JSDBContext context) : base(context) { }
    }

    public class ClientAccountRepository : Repository<ClientAccount>, IClientAccountRepository
    {
        public ClientAccountRepository(JSDBContext context) : base(context) { }
    }

    public class ClientRoleRepository : Repository<ClientRole>, IClientRoleRepository
    {
        public ClientRoleRepository(JSDBContext context) : base(context) { }
    }

    public class ClientRolePermissionRepository : Repository<ClientRolePermission>, IClientRolePermissionRepository
    {
        public ClientRolePermissionRepository(JSDBContext context) : base(context) { }
    }

    public class CommentRepository : Repository<Comment>, ICommentRepository
    {
        public CommentRepository(JSDBContext context) : base(context) { }
    }

    public class CountryRepository : Repository<Entities.Country>, ICountryRepository
    {
        public CountryRepository(JSDBContext context) : base(context) { }
    }

    public class FabricTypeRepository : Repository<JsTblFabricType>, IFabricTypeRepository
    {
        public FabricTypeRepository(JSDBContext context) : base(context) { }
    }

    public class FlowStepNameRepository : Repository<FlowStepName>, IFlowStepNameRepository
    {
        public FlowStepNameRepository(JSDBContext context) : base(context) { }
    }

    public class GRNRepository : Repository<GRN>, IGRNRepository
    {
        public GRNRepository(JSDBContext context) : base(context) { }
    }

    public class ItemRepository : Repository<Item>, IItemRepository
    {
        public ItemRepository(JSDBContext context) : base(context) { }
    }

    public class ItemAdjustmentRepository : Repository<ItemAdjustment>, IItemAdjustmentRepository
    {
        public ItemAdjustmentRepository(JSDBContext context) : base(context) { }
    }

    public class ItemCategoryRepository : Repository<ItemCategory>, IItemCategoryRepository
    {
        public ItemCategoryRepository(JSDBContext context) : base(context) { }
    }

    public class LookUpTypeRepository : Repository<LookUpType>, ILookUpTypeRepository
    {
        public LookUpTypeRepository(JSDBContext context) : base(context) { }
    }

    public class LookUpValueRepository : Repository<LookUpValue>, ILookUpValueRepository
    {
        public LookUpValueRepository(JSDBContext context) : base(context) { }
    }

    public class MockOrderClientAttachmentRepository : Repository<MockOrderClientAttachment>, IMockOrderClientAttachmentRepository
    {
        public MockOrderClientAttachmentRepository(JSDBContext context) : base(context) { }
    }

    public class MockOrderDesignAttachmentRepository : Repository<MockOrderDesignAttachment>, IMockOrderDesignAttachmentRepository
    {
        public MockOrderDesignAttachmentRepository(JSDBContext context) : base(context) { }
    }

    public class MockOrderRequestRepository : Repository<MockOrderRequest>, IMockOrderRequestRepository
    {
        public MockOrderRequestRepository(JSDBContext context) : base(context) { }
    }

    public class NeckStyleRepository : Repository<JsTblNeckStyle>, INeckStyleRepository
    {
        public NeckStyleRepository(JSDBContext context) : base(context) { }
    }

    public class OrderFlowGroupRepository : Repository<OrderFlowGroup>, IOrderFlowGroupRepository
    {
        public OrderFlowGroupRepository(JSDBContext context) : base(context) { }
    }

    public class PriceListRepository : Repository<PriceList>, IPriceListRepository
    {
        public PriceListRepository(JSDBContext context) : base(context) { }
    }
}
