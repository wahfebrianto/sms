//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminLTE1
{
    using System;
    using System.Collections.Generic;
    
    public partial class hsalesinvoice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hsalesinvoice()
        {
            this.dsalesinvoices = new HashSet<dsalesinvoice>();
            this.salesinvoicenotes = new HashSet<salesinvoicenote>();
        }
    
        public long id { get; set; }
        public long projectid { get; set; }
        public string number { get; set; }
        public System.DateTime date { get; set; }
        public string terms { get; set; }
        public string to { get; set; }
        public long total { get; set; }
        public string description { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dsalesinvoice> dsalesinvoices { get; set; }
        public virtual project project { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<salesinvoicenote> salesinvoicenotes { get; set; }
    }
}
