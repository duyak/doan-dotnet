//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Website_StorePhone3.Models.DB
{
    using System;
    using System.Collections.Generic;
    
    public partial class voucher
    {
        public int id { get; set; }
        public string name { get; set; }
        public System.DateTime startDate { get; set; }
        public System.DateTime endDate { get; set; }
        public int productId { get; set; }
        public int productVoucherId { get; set; }
        public int percentage { get; set; }
        public int activeFlag { get; set; }
        public System.DateTime createDate { get; set; }
        public System.DateTime updateDate { get; set; }
    
        public virtual product product { get; set; }
        public virtual product product1 { get; set; }
    }
}