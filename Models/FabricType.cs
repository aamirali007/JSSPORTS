using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportsOrderApp.Models
{
    public class FabricType
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long FabricTypeId { get; set; }

        [StringLength(100)]
        public string FabricTypeName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }
}
