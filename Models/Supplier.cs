using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportsOrderApp.Models
{
    public class Supplier
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long SupplierId { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        [StringLength(50)]
        public string CompanyName { get; set; }

        [StringLength(50)]
        public string MobileNo { get; set; }

        [StringLength(50)]
        public string MobileNo2 { get; set; }

        [StringLength(50)]
        public string Phone { get; set; }

        [StringLength(50)]
        public string Phone2 { get; set; }

        [StringLength(50)]
        public string Fax { get; set; }

        [StringLength(50)]
        public string CNIC { get; set; }

        public long CityId { get; set; }

        [StringLength(50)]
        public string Street { get; set; }

        [StringLength(50)]
        public string Address1 { get; set; }

        [StringLength(50)]
        public string Address2 { get; set; }

        [StringLength(50)]
        public string NTNNo { get; set; }

        [StringLength(50)]
        public string ContactName { get; set; }

        [StringLength(50)]
        public string ContactTitle { get; set; }

        [StringLength(50)]
        public string Email { get; set; }

        [StringLength(50)]
        public string Email2 { get; set; }

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
