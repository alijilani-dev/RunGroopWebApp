using System.ComponentModel.DataAnnotations;

namespace RunGroopWebApp.Models
{
    public class Address
    {
        [Key]
        public int Id { get; set; }

        public string Street { get; set; } = "Unknown";

        public string City { get; set; } = "Unknown";

        public string State { get; set; } = "Unknown";

    }
}
