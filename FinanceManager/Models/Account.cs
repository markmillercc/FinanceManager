using System;
using System.Collections.Generic;
using System.Linq;

namespace FinanceManager.Models
{
    public partial class Account
    {
        private AccountLedger _ledger;
        public ApplicationUser PrimaryOwner { get; private set; }

        private ICollection<ApplicationUser> _secondaryOwners;
        public IEnumerable<ApplicationUser> SecondaryOwners { get { return _secondaryOwners; } }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public double Balance { get { return _ledger.Entries.Sum(a => a.Amount); } }

        private Account()
        {
            _ledger = new AccountLedger();
            _secondaryOwners = new HashSet<ApplicationUser>();
        }

        public Account(ApplicationUser primaryOwner)
        {
            if (primaryOwner == null)
                throw new ArgumentNullException("primaryOwner", "Owner cannot be null");

            PrimaryOwner = primaryOwner;
        }

        public void Credit(double amount, string description)
        {
            if (amount < 0)
                throw new InvalidOperationException("Amount cannot be negative");

            _ledger.AddEntry(new AccountLedgerEntry(amount, description));
        }

        public void Debit(double amount, string description)
        {
            if (amount < 0)
                throw new InvalidOperationException("Amount cannot be negative");

            _ledger.AddEntry(new AccountLedgerEntry(amount * -1, description));
        }

        public void AddSecondaryOwner(ApplicationUser user)
        {
            if (user == null)
                throw new ArgumentNullException("user", "User cannot be null");

            if (_secondaryOwners.Contains(user))
                throw new InvalidOperationException("User is already an owner for this account");

            _secondaryOwners.Add(user);
        }

        public void RemoveSecondaryOwner(ApplicationUser owner)
        {
            if (owner == null)
                throw new ArgumentNullException("owner", "Owner cannot be null");

            _secondaryOwners.Remove(owner);
        }
    }
}