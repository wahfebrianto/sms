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
    
    public partial class hpo
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public hpo()
        {
            this.dpoes = new HashSet<dpo>();
            this.hreceiveitems = new HashSet<hreceiveitem>();
            this.hpurchaseinvoices = new HashSet<hpurchaseinvoice>();
        }
    
        public long id { get; set; }
        public long projectid { get; set; }
        public string number { get; set; }
        public long supplierid { get; set; }
        public System.DateTime date { get; set; }
        public string terms { get; set; }
        public string to { get; set; }
        public System.DateTime expecteddate { get; set; }
        public long grandtotal { get; set; }
        public string description { get; set; }
        public long total { get; set; }
        public long dp { get; set; }
        public long discount { get; set; }
        public byte status { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dpo> dpoes { get; set; }
        public virtual project project { get; set; }
        public virtual supplier supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hreceiveitem> hreceiveitems { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<hpurchaseinvoice> hpurchaseinvoices { get; set; }
    }
}
