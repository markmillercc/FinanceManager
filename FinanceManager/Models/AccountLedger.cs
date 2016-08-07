using System.Collections.Generic;

namespace FinanceManager.Models
{
    public partial class AccountLedger
    {
        public int Id { get; set; }

        private ICollection<AccountLedgerEntry> _entries;
        public IEnumerable<AccountLedgerEntry> Entries { get { return _entries; } }

        public AccountLedger()
        {
            _entries = new HashSet<AccountLedgerEntry>();
        }

        public void AddEntry(AccountLedgerEntry entry)
        {
            _entries.Add(entry);
        }
    }
}