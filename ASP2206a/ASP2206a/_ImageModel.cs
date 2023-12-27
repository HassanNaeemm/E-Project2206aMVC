using System.ComponentModel.DataAnnotations;

namespace ASP2206a
{
	public class _ImageModel
	{

		[Key]
		public int id { get; set; }
		[Required]
		public string name { get; set; }
		[Required]
		public string email { get; set; }
		[Required]
		public string password { get; set; }
		[Required]
		public IFormFile Photo { get; set; }
	}
}
