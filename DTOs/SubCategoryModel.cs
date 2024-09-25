namespace SportsOrderApp.DTOs
{
    public class SubCategoryModel
    {
        public long SubCategoryId { get; set; }
        public long? CategoryId { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public bool? IsDefault { get; set; }
        public bool? Active { get; set; }
        public bool? Deleted { get; set; }
    }
    public class SubCategoryAddModel
    {
        public long SubCategoryId { get; set; }
        public long? CategoryId { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }

    }
}
