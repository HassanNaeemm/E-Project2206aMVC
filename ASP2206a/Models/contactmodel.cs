using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace ASP2206a.Models
{
    public class contactmodel
    {
        [Key]
        public int contactid { get; set; }
        [Required]
        public string username { get; set; }
        [Required]
        public string lastname { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string message { get; set; }
    }
}
