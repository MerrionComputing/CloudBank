using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CloudBank.RetailBank
{
    /// <summary>
    /// The data payload that can be sent when opening a bank account
    /// </summary>
    /// <remarks>
    /// OpenAccount/{accountnumber}
    /// </remarks>
    public class AccountOpeningData
    {

        /// <summary>
        /// The text commentary provided when opening the new bank account
        /// </summary>
        [Parameter]
        [Required]
        public string Commentary { get; set; }

        /// <summary>
        /// The initial balance used to open the account
        /// </summary>
        [Parameter]
        [Range(0.00, Double.MaxValue , ErrorMessage="Initial balance must be greater than or equal to zero" ) ]
        public Nullable<decimal> OpeningBalance { get; set; }

        /// <summary>
        /// The client in whose name the account is opened
        /// </summary>
        [Parameter]
        [Required(AllowEmptyStrings =false , ErrorMessage = "Please supply a client name for the new account")]
        public string ClientName { get; set; }

    }
}
