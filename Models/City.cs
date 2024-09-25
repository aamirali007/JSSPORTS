using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportsOrderApp.Models
{
    public class City
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CityId { get; set; }

        [StringLength(50)]
        public string CityName { get; set; }

        public long StateId { get; set; }

        [ForeignKey("StateId")]
        public State State { get; set; }
    }
}
