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
    
    public partial class hrfq
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hrfq()
        {
            this.drfqs = new HashSet<drfq>();
            this.rfqnotes = new HashSet<rfqnote>();
        }
    
        public long id { get; set; }
        public string number { get; set; }
        public System.DateTime date { get; set; }
        public long customerid { get; set; }
        public string to { get; set; }
        public string description { get; set; }
        public long projectid { get; set; }
    
        public virtual customer customer { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<drfq> drfqs { get; set; }
        public virtual project project { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<rfqnote> rfqnotes { get; set; }
    }
}