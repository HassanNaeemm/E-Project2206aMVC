using System.ComponentModel.DataAnnotations;

namespace ASP2206a.Models
{
	public class ImageModel
	{
		[Key]
		public int id { get; set; }
		[Required]
		public string name { get; set; }
		[Required]
		public string email{ get; set; }
		[Required]
		public string password { get; set; }
		[Required]
		public string image { get; set; }

	}
}
