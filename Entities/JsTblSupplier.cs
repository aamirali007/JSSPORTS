using System;
using System.Collections.Generic;

namespace SportsOrderApp.Entities
{
    public partial class JsTblSupplier
    {
        public long SupplierId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? CompanyName { get; set; }
        public string? MobileNo { get; set; }
        public string? MobileNo2 { get; set; }
        public string? Phone { get; set; }
        public string? Phone2 { get; set; }
        public string? Fax { get; set; }
        public string? Cnic { get; set; }
        public long? CityId { get; set; }
        public string? Street { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? NtnNo { get; set; }
        public string? ContactName { get; set; }
        public string? ContactTitle { get; set; }
        public string? Email { get; set; }
        public string? Email2 { get; set; }
        public string? CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool? Active { get; set; }
        public bool? Deleted { get; set; }
        public int? Attribute1 { get; set; }
        public int? Attribute2 { get; set; }
        public int? Attribute3 { get; set; }
        public int? Attribute4 { get; set; }
        public int? Attribute5 { get; set; }
        public string? Attribute6 { get; set; }
        public string? Attribute7 { get; set; }
        public string? Attribute8 { get; set; }
        public string? Attribute9 { get; set; }
        public string? Attribute10 { get; set; }
        public bool? Attribute11 { get; set; }
        public bool? Attribute12 { get; set; }
        public bool? Attribute13 { get; set; }
        public bool? Attribute14 { get; set; }
        public bool? Attribute15 { get; set; }

        public virtual City? City { get; set; }
    }
}
