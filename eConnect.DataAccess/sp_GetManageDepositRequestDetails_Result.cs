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
    
    public partial class sp_GetManageDepositRequestDetails_Result
    {
        public Nullable<int> RaisedBy { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> RequestedDate { get; set; }
        public Nullable<System.DateTime> CompletionDate { get; set; }
        public Nullable<bool> HasReceipt { get; set; }
        public string ReceiptSource { get; set; }
        public int DepositeRequestId { get; set; }
        public string Comment { get; set; }
        public int CSPId { get; set; }
        public string CSPName { get; set; }
        public string CSPCode { get; set; }
        public Nullable<int> Country { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<int> City { get; set; }
        public string Location { get; set; }
        public Nullable<bool> IsVerified { get; set; }
        public string CSPAccount { get; set; }
        public string Comment1 { get; set; }
        public string BranchCode { get; set; }
        public string Category { get; set; }
        public Nullable<System.DateTime> DepositDate { get; set; }
    }
}
