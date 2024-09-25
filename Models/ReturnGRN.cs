using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportsOrderApp.Models
{
    public class ReturnGRN
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ReturnId { get; set; }

        public long GrnId { get; set; }

        public DateTime ReturnDate { get; set; }

        public long ItemId { get; set; }

        public int ReturnQuantity { get; set; }

        [StringLength(500)]
        public string ReasonForReturn { get; set; }

        [StringLength(100)]
        public string WarehouseLocation { get; set; }

        [StringLength(50)]
        public string ProcessedBy { get; set; }

        [StringLength(500)]
        public string Comments { get; set; }

        [ForeignKey("GrnId")]
        public GRN Grn { get; set; }

        [ForeignKey("ItemId")]
        public Item Item { get; set; }
        [StringLength(50)]
        public string CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public bool Active { get; set; }

        public bool Deleted { get; set; }

        public int? Attribute1 { get; set; }

        public int? Attribute2 { get; set; }

        public int? Attribute3 { get; set; }

        public int? Attribute4 { get; set; }

        public int? Attribute5 { get; set; }

        [StringLength(50)]
        public string Attribute6 { get; set; }

        [StringLength(50)]
        public string Attribute7 { get; set; }

        [StringLength(50)]
        public string Attribute8 { get; set; }

        [StringLength(50)]
        public string Attribute9 { get; set; }

        [StringLength(50)]
        public string Attribute10 { get; set; }

        public bool? Attribute11 { get; set; }

        public bool? Attribute12 { get; set; }

        public bool? Attribute13 { get; set; }

        public bool? Attribute14 { get; set; }

        public bool? Attribute15 { get; set; }
    }
}
