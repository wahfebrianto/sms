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
    
    public partial class dreceiveitem
    {
        public long id { get; set; }
        public Nullable<long> receiveitemid { get; set; }
        public Nullable<long> itemcategoryid { get; set; }
        public string itemdescription { get; set; }
        public Nullable<long> qty { get; set; }
    
        public virtual hreceiveitem hreceiveitem { get; set; }
        public virtual item_category item_category { get; set; }
    }
}
