using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportsOrderApp.Models
{
    public class NeckStyle
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long NeckStyleId { get; set; }

        [StringLength(100)]
        public string NeckStyleName { get; set; }

        [StringLength(500)]
        public string Description { get; set; }
    }
}
