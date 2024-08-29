using System.ComponentModel.DataAnnotations;

namespace AdminWeb.Models
{
	public class ResponseMessage
	{
		[Key]
		public int Id { get; set; }
		public string? Message { get;set; }
	}
}
