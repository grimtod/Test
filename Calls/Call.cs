using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calls
{
	[Table("Calls")]
	public class Call
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
		public int Id { get; set; }

		[Required]
		public PhoneNumber Caller { get; set; }

		[Required]
		public PhoneNumber Receiver { get; set; }

		public long Duration { get; set; }
	}
}
