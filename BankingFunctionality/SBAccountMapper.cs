using System;
using System.Collections.Generic;
using BankLibrary.Models;

#nullable disable

namespace BankingFunctionality
{
    public partial class SBaccountMapper
    {
        public int Accno { get; set; }
        public decimal? Bal { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
    }
}
