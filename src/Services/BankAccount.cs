using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudBank.Services
{
    /// <summary>
    /// Services for an individual bank account
    /// </summary>
    public class BankAccount
        : IBankAccount
    {

        /// <summary>
        /// The unique number of the bank account
        /// </summary>
        public string BankAccountNumber { get; set; }

    }
}
