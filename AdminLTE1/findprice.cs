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
    
    public partial class findprice
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public findprice()
        {
            this.findpricesnotes = new HashSet<findpricesnote>();
        }
    
        public long id { get; set; }
        public long projectid { get; set; }
        public long supplierid { get; set; }
        public string address { get; set; }
        public string itemdescription { get; set; }
        public long unitprice { get; set; }
        public long timeneeded { get; set; }
        public string description { get; set; }
        public byte status { get; set; }
    
        public virtual supplier supplier { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<findpricesnote> findpricesnotes { get; set; }
        public virtual project project { get; set; }
    }
}
