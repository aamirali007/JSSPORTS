namespace SportsOrderApp.DTOs
{
    public class AddNewMockup
    {
        public long MockupId { get; set; }
        public int MainCategoryId { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string TeamName { get; set; }
        public int FabricTypeId { get; set; }
        public string FabricType { get; set; }
        public int NeckStyleId { get; set; }
        public string NeckStyle { get; set; }
        public string? FrontDescription { get; set; }
        public string? BackDescription { get; set; }
        public string? LeftSleeveDesc { get; set; }
        public string? RightSleeveDesc { get; set; }
        public string AdditionalDetail { get; set; }
        public List<string> FrontImages { get; set; }
        public List<string> BackImages { get; set; }
        public string? MockupName { get; set; }
        public string? MockupCode { get; set; }
    }
}
