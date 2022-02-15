using System;
using System.Collections.Generic;
using BankLibrary.Models;
#nullable disable

namespace BankingFunctionality
{
    public partial class SBTransactionMapper
    {
       
        public int TransId { get; set; }
        public int? Accno { get; set; }
        public decimal? Amt { get; set; }
        public string TransType { get; set; }
        public DateTime? TransDate { get; set; }
    }
}
