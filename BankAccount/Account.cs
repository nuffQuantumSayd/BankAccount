using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    /// <summary>
    /// Represents a single costomers bank account
    /// </summary>
    public class Account
    {
        /// <summary>
        /// Creates an account with a specific owner and a balance of 0
        /// </summary>
        /// <param name="accOwner">The Owner of the account</param>
        public Account(string accOwner)
        {
            Owner = accOwner;
        }

        /// <summary>
        /// The account holders full name
        /// </summary>
        public string? Owner { get; set; }

        /// <summary>
        /// The amount of money currently in the account
        /// </summary>
        public double Balance { get; private set; }

        /// <summary>
        /// Add a specified amount of money to the account
        /// </summary>
        /// <param name="amt">The positive amount to deposit</param>
        public double Deposit(double amt)
        {
            Balance += amt;
            return Balance;
        }

        /// <summary>
        /// Withdraws an amount of money from the balance
        /// </summary>
        /// <param name="amt">The positive amount of money to
        /// be taken from the balance</param>
        public void Withdraw(double amt)
        {
            throw new NotImplementedException();
        }
    }
}
