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
    
    public partial class tblWithdrawalRequest
    {
        public long WithdrawalRequestId { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> RaisedBy { get; set; }
        public Nullable<byte> Status { get; set; }
        public Nullable<System.DateTime> RequestedDate { get; set; }
        public Nullable<System.DateTime> CompletionDate { get; set; }
        public Nullable<bool> IsConfigured { get; set; }
        public Nullable<bool> IsMake { get; set; }
        public Nullable<bool> IsAuthorized { get; set; }
        public string ResolutionDetail { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<long> Account { get; set; }
    
        public virtual tblStatu tblStatu { get; set; }
        public virtual tblUser tblUser { get; set; }
        public virtual tblUser tblUser1 { get; set; }
    }
}
