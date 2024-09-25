using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SportsOrderApp.Models
{
    public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long CountryId { get; set; }

        [StringLength(50)]
        public string CountryName { get; set; }

        public ICollection<State> States { get; set; }
    }
}
