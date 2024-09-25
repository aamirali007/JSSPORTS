using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportsOrderApp.Models
{
    public class State
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long StateId { get; set; }

        [StringLength(50)]
        public string StateName { get; set; }

        public long CountryId { get; set; }

        [ForeignKey("CountryId")]
        public Country Country { get; set; }

        public ICollection<City> Cities { get; set; }
    }
}
