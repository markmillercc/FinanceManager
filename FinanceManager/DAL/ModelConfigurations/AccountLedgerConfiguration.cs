using FinanceManager.Models;
using System.Data.Entity.ModelConfiguration;

namespace FinanceManager.DAL.ModelConfigurations
{
    public class AccountLedgerConfiguration : EntityTypeConfiguration<AccountLedger>
    {
        public AccountLedgerConfiguration()
        {            
        }
    }
}