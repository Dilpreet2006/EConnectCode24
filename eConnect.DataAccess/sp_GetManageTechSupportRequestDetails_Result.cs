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
    
    public partial class sp_GetManageTechSupportRequestDetails_Result
    {
        public long TechRequestId { get; set; }
        public Nullable<int> RaisedBy { get; set; }
        public int CSPId { get; set; }
        public string CSPName { get; set; }
        public string CSPCode { get; set; }
        public string Summary { get; set; }
        public Nullable<int> ProblemType { get; set; }
        public string Description { get; set; }
        public string MobileNo { get; set; }
        public Nullable<int> Status { get; set; }
        public Nullable<System.DateTime> RequestedDate { get; set; }
        public string Rdate { get; set; }
        public string Cdate { get; set; }
        public Nullable<System.DateTime> CompletionDate { get; set; }
        public Nullable<int> ResolutionProvidedBy { get; set; }
        public string ResolutionDetail { get; set; }
        public string Attachment { get; set; }
        public string AttachmentSource { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> CreatedBy { get; set; }
        public string Comment { get; set; }
        public string AnyDeskDetail { get; set; }
        public Nullable<int> Country { get; set; }
        public Nullable<int> State { get; set; }
        public Nullable<int> City { get; set; }
        public Nullable<int> City1 { get; set; }
        public string Location { get; set; }
        public string CSPAccount { get; set; }
        public string BranchCode { get; set; }
        public string Category { get; set; }
    }
}
