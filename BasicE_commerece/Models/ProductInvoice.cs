//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BasicE_commerece.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProductInvoice
    {
        public int ProductInvoiceId { get; set; }
        public int InvoiceId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public System.DateTime Date { get; set; }
        public double Price { get; set; }
        public double Pay { get; set; }
        public double Due { get; set; }
    
        public virtual Invoice Invoice { get; set; }
        public virtual Product Product { get; set; }
    }
}
