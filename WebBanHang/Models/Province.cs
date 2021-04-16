//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebBanHang.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Province
    {
        public Province()
        {
            this.Customers = new HashSet<Customer>();
            this.Districts = new HashSet<District>();
            this.Orders = new HashSet<Order>();
        }
    
        public int ProvinceID { get; set; }
        public string ProvinceName { get; set; }
        public string Type { get; set; }
    
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<District> Districts { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
