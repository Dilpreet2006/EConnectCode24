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
    
    public partial class tblCommissionReportTransactionType
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblCommissionReportTransactionType()
        {
            this.tblCommissionReports = new HashSet<tblCommissionReport>();
        }
    
        public int CommissionReportTransactionTypeId { get; set; }
        public string Name { get; set; }
        public Nullable<decimal> HOCommission { get; set; }
        public Nullable<decimal> CSPCommission { get; set; }
        public Nullable<bool> Status { get; set; }
        public Nullable<int> CycleID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCommissionReport> tblCommissionReports { get; set; }
        public virtual tblCommissionReportTransactionType tblCommissionReportTransactionType1 { get; set; }
        public virtual tblCommissionReportTransactionType tblCommissionReportTransactionType2 { get; set; }
    }
}
