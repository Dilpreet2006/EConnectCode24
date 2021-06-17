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
    using System.Collections.Generic;
    
    public partial class tblDepositRequest
    {
        public long DepositeRequestId { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> RaisedBy { get; set; }
        public Nullable<byte> Status { get; set; }
        public Nullable<System.DateTime> RequestedDate { get; set; }
        public Nullable<System.DateTime> CompletionDate { get; set; }
        public Nullable<bool> HasReceipt { get; set; }
        public string ReceiptSource { get; set; }
        public Nullable<bool> IsVerified { get; set; }
        public string ResolutionDetail { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual tblCSPDetail tblCSPDetail { get; set; }
        public virtual tblStatu tblStatu { get; set; }
        public virtual tblUser tblUser { get; set; }
        public virtual tblUser tblUser1 { get; set; }
    }
}
