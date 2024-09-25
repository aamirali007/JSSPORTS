using SportsOrderApp.Entities;

namespace SportsOrderApp.DTOs
{
    public class MockupModel
    {
        public long MockupId { get; set; }
        public string? TeamName { get; set; }
        public long? MainCategoryId { get; set; }
        public long? CategoryId { get; set; }
        public long? SubCategoryId { get; set; }
        public long? ProductId { get; set; }
        public long? FabricTypeId { get; set; }
        public long? NeckStyleId { get; set; }
        public string? FrontDescription { get; set; }
        public string? BackDescription { get; set; }
        public string? LeftSleeveDesc { get; set; }
        public string? RightSleeveDesc { get; set; }
        public bool? Active { get; set; }
        public string? Status { get; set; }
        public bool? Deleted { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public long? UserId { get; set; }
        public string? OnlyDesc { get; set; }

        public  CategoryModel? Category { get; set; }
        public  FabricTypeModel? FabricType { get; set; }
        public  MainCategoryModel? MainCategory { get; set; }
        public  NeckStyleModel? NeckStyle { get; set; }
        public  ProductModel? Product { get; set; }
        public  SubCategoryModel? SubCategory { get; set; }
        public  UserListModel? User { get; set; }
        //public virtual ICollection<JsTblMockupAttachment> JsTblMockupAttachments { get; set; }
    }

    public class ApprovedMockupModel
    {
        public long MockupId { get; set; }
        public string? TeamName { get; set; }
        public long? MainCategoryId { get; set; }
        public long? CategoryId { get; set; }
        public long? SubCategoryId { get; set; }
        public long? ProductId { get; set; }
        public long? FabricTypeId { get; set; }
        public long? NeckStyleId { get; set; }
        public string? FrontDescription { get; set; }
        public string? BackDescription { get; set; }
        public string? LeftSleeveDesc { get; set; }
        public string? RightSleeveDesc { get; set; }
    }
}
