namespace SportsOrderApp.DTOs
{
    public class ProductModel
    {
        public long ProductId { get; set; }
        public long? SubCategoryId { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public bool? IsDefault { get; set; }
        public bool? Active { get; set; }
        public string? Status { get; set; }
        public bool? Deleted { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? IsNeck { get; set; }
        public bool? IsFrontDesc { get; set; }
        public bool? IsFrontImage { get; set; }
        public bool? IsBackDesc { get; set; }
        public bool? IsBackImage { get; set; }
        public bool? IsOnlyDesc { get; set; }
        public bool? IsLeftSleeveDesc { get; set; }
        public bool? IsRightSleeveDesc { get; set; }
        public bool? IsLeftSleeveImage { get; set; }
        public bool? IsRightSleeveImage { get; set; }
        public string? FrontImage { get; set; }
        public string? BackImage { get; set; }
    }
    public class ProductAddModel
    {
        public long ProductId { get; set; }
        public long? SubCategoryId { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public bool? IsNeck { get; set; }
        public bool? IsFrontDesc { get; set; }
        public bool? IsFrontImage { get; set; }
        public bool? IsBackDesc { get; set; }
        public bool? IsBackImage { get; set; }
        public bool? IsOnlyDesc { get; set; }
        public bool? IsLeftSleeveDesc { get; set; }
        public bool? IsRightSleeveDesc { get; set; }
        public bool? IsLeftSleeveImage { get; set; }
        public bool? IsRightSleeveImage { get; set; }
        public string? FrontImage { get; set; }
        public string? BackImage { get; set; }
    }
}
