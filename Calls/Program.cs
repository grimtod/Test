using System.Data.Entity;
using Calls.Migrations;

namespace Calls
{
	class Program
	{
		static void Main(string[] args)
		{
			Database.SetInitializer(new MigrateDatabaseToLatestVersion<CallsDbContext, Configuration>());
		}
	}
}
