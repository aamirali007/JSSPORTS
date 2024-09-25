namespace SportsOrderApp.DTOs
{
    public class ProductSizeListModel
    {
        public long ProductSizeId { get; set; }
        public string? Name { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }
        public bool? IsOverSize { get; set; }
    }
}
