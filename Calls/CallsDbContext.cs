using System.Data.Entity;

namespace Calls
{
	public class CallsDbContext : DbContext
	{
		public CallsDbContext() : base("Calls")
		{
		}

		public DbSet<Call> Calls { get; set; }

		public DbSet<PhoneNumber> PhoneNumbers { get; set; }
	}
}
