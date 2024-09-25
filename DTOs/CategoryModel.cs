namespace SportsOrderApp.DTOs
{
    public class CategoryModel
    {
        public long CategoryId { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public long? MainCategoryId { get; set; }
        public bool? IsDefault { get; set; }
        public bool? Active { get; set; }
        public bool? Deleted { get; set; }
    }
    public class CategoryAddModel
    {
        public long CategoryId { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public long? MainCategoryId { get; set; }
    }
}
