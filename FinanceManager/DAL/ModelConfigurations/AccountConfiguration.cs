using FinanceManager.Models;
using System.Data.Entity.ModelConfiguration;

namespace FinanceManager.DAL.ModelConfigurations
{
    public class AccountConfiguration : EntityTypeConfiguration<Account>
    {
        public AccountConfiguration()
        {
        }
    }
}