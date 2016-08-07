using FinanceManager.Models;
using System.Data.Entity.ModelConfiguration;

namespace FinanceManager.DAL.ModelConfigurations
{
    public class ApplicationUserConfiguration : EntityTypeConfiguration<ApplicationUser>
	{
        public ApplicationUserConfiguration()
        {
        }         
	}
}