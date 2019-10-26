using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CloudBank.RetailBank
{
    public class MoneyDepositData
    {
        /// <summary>
        /// The text commentary provided when depositing money in an account
        /// </summary>
        [Parameter]
        [Required(ErrorMessage = "Comments are required for the deposit")]
        public string Commentary { get; set; }

        /// <summary>
        /// The amount deposited
        /// </summary>
        [Parameter]
        [Range(0.01, Double.MaxValue, ErrorMessage = "Amount to deposit must be greater than zero")]
        public decimal DepositAmount { get; set; }

        /// <summary>
        /// Where did the deposit come from
        /// </summary>
        [Parameter]
        [Required(ErrorMessage = "Please specify a deposit source")]
        public string Source { get; set; }

    }
}
