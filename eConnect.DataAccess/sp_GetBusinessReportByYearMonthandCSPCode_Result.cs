//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace eConnect.DataAccess
{
    using System;
    
    public partial class sp_GetBusinessReportByYearMonthandCSPCode_Result
    {
        public long BusinessDetailReportId { get; set; }
        public Nullable<int> UploaderId { get; set; }
        public Nullable<int> Month { get; set; }
        public Nullable<int> Year { get; set; }
        public string CSPCode { get; set; }
        public Nullable<int> SavingsAccountEnrollment { get; set; }
        public Nullable<int> SavingsAccountOpen { get; set; }
        public Nullable<int> SHGAccountEnrollment { get; set; }
        public Nullable<int> SHGAccountOpen { get; set; }
        public Nullable<int> StateATMCards { get; set; }
        public Nullable<int> CashReceiptNo { get; set; }
        public Nullable<decimal> CashReceiptAmount { get; set; }
        public Nullable<int> CashPaymentNo { get; set; }
        public Nullable<decimal> CashPaymentAmount { get; set; }
        public Nullable<int> FundTransferNo { get; set; }
        public Nullable<decimal> FundTransferAmount { get; set; }
        public Nullable<int> MoneyTransferNo { get; set; }
        public Nullable<decimal> MoneyTransferAmount { get; set; }
        public Nullable<int> IMPSNo { get; set; }
        public Nullable<decimal> IMPSAmount { get; set; }
        public Nullable<int> STDRNo { get; set; }
        public Nullable<decimal> STDRAmount { get; set; }
        public Nullable<int> LoanDepositNo { get; set; }
        public Nullable<decimal> LoanDepositAmount { get; set; }
        public Nullable<int> RDRemittanceNo { get; set; }
        public Nullable<decimal> RDRemittanceAmount { get; set; }
        public Nullable<int> RDACOpenNo { get; set; }
        public Nullable<decimal> RDACOpenAmount { get; set; }
        public string Category { get; set; }
        public string CSPName { get; set; }
        public Nullable<int> NoOfTransaction { get; set; }
        public Nullable<int> AverageTransaction { get; set; }
    }
}
