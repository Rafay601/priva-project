//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_projectPriva.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Insurance_Customer
    {
        public int Id { get; set; }
        public string CNIC { get; set; }
        public Nullable<int> Car_Id { get; set; }
        public string Date { get; set; }
        public string Insurance_Type { get; set; }
        public string Card_No { get; set; }
        public string Expire_Date { get; set; }
        public string CVV { get; set; }
        public Nullable<int> Plan_Id { get; set; }
        public Nullable<int> cust_id { get; set; }
    
        public virtual Vehicle Vehicle { get; set; }
        public virtual Policy Policy { get; set; }
        public virtual Customer Customer { get; set; }
    }
}
