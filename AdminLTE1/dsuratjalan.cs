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
    
    public partial class dsuratjalan
    {
        public long id { get; set; }
        public long suratjalanid { get; set; }
        public long itemcategoryid { get; set; }
        public string itemdescription { get; set; }
        public long qty { get; set; }
    
        public virtual hsuratjalan hsuratjalan { get; set; }
        public virtual item_category item_category { get; set; }
    }
}
