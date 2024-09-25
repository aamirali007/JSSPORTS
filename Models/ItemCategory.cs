using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportsOrderApp.Models
{
    public class ItemCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long ItemCategoryId { get; set; }

        [StringLength(50)]
        public string ItemCategoryName { get; set; }

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
