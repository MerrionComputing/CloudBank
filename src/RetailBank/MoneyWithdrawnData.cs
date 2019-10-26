using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CloudBank.RetailBank
{
    public class MoneyWithdrawnData
    {

        /// <summary>
        /// The amount of money to be withdrawn into the account
        /// </summary>
        [Parameter]
        [Range(0.01, Double.MaxValue, ErrorMessage = "Amount to withdraw must be greater than zero")]
        public decimal AmountWithdrawn { get; set; }

        /// <summary>
        /// The commentary attached to the money withdrawal 
        /// </summary>
        [Parameter]
        [Required(ErrorMessage = "Comments are required for the withdrawal request")]
        public string Commentary { get; set; }

    }
}
