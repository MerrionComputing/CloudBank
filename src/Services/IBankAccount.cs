using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloudBank.Services
{
    public interface IBankAccount
    {
        string BankAccountNumber { get; set; }
    }
}
