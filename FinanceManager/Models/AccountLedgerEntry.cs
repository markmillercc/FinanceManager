using System;

namespace FinanceManager.Models
{
    public partial class AccountLedgerEntry
    {
        public AccountLedgerEntry(double amount, string description)
        {
            Amount = amount;
            Description = description;
            CreatedUtc = DateTime.UtcNow;
        }

        public int Id { get; set; }
        public double Amount { get; private set; }
        public string Description { get; set; }
        public DateTime CreatedUtc { get; private set; }
    }    
}