using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportsOrderApp.Models
{
    public class SubCategory
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long SubCategoryId { get; set; }

        [StringLength(100)]
        public string SubCategoryName { get; set; }

        public long CategoryId { get; set; }

        [StringLength(500)]
        public string Description { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }
}
