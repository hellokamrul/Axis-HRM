using Axis.Core.Models;
using Axis.Core.Models.HR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Axis.Application.DTOs.HR
{
    public class BankInfoDTO : BaseDTO
    {
        //public string BankId { get; set; }
        public string BankName { get; set; }
        public string BankBranch { get; set; }
        public string AccountNumber { get; set; }
        public string AccountName { get; set; }
        public string AccountType { get; set; }
        public string SwiftCode { get; set; }
        public string Iban { get; set; }
        public string Currency { get; set; }
        public string BankAddress { get; set; }
        public string BankCity { get; set; }
        public string BankCountry { get; set; }
        public string BankPhone { get; set; }
        public string BankFax { get; set; }
        public string BankEmail { get; set; }
        public string BankWebsite { get; set; }
        public string BankContactPerson { get; set; }
        public string BankContactPersonPhone { get; set; }
        public string? EmpId { get; set; }

    }
}
