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
    
    public partial class purchaseinvoicenote
    {
        public long id { get; set; }
        public long projectid { get; set; }
        public string username { get; set; }
        public System.DateTime date { get; set; }
        public string text { get; set; }
    
        public virtual project project { get; set; }
    }
}
