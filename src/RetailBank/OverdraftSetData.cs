using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CloudBank.RetailBank
{
    /// <summary>
    /// The data payload for a function to set the overdraft for an account
    /// </summary>
    public class OverdraftSetData
    {
        /// <summary>
        /// The new overdraft limitthe account
        /// </summary>
        [Parameter]
        [Range(0.00, Double.MaxValue, ErrorMessage = "New overdraft limit must greater than or equal to zero")]
        public decimal NewOverdraftLimit { get; set; }

        /// <summary>
        /// The commentary attached to the overdraft limit 
        /// </summary>
        [Parameter]
        [Required(ErrorMessage = "Comments are required for the overdraft request") ]
        public string Commentary { get; set; }
    }
}
