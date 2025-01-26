using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RunGroopWebApp.Data.Enum;

namespace RunGroopWebApp.Models
{
    public class Club
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = "Unknown";
        public string Description { get; set; } = "Unknown";
        public string Image { get; set; } = "Unknown";
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public ClubCategory ClubCategory { get; set; }
        [ForeignKey("AppUser")]
        public string? AppUserId { get; set; }
        public AppUser? AppUser { get; set; }
    }
}
