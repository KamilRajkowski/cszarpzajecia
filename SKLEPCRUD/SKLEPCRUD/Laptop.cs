//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SKLEPCRUD
{
    using System;
    using System.Collections.Generic;
    
    public partial class Laptop
    {
        public string model { get; set; }
        public int procesor { get; set; }
        public int ram { get; set; }
        public int hdd { get; set; }
        public int ekran { get; set; }
        public decimal cena { get; set; }
    
        public virtual Produkty Produkty { get; set; }
    }
}
