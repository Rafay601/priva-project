using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace E_projectPriva.Models
{
    public class insurance
    {
        public int Id { get; set; }
        
        public string Car_Model { get; set; }
        public string Car_Brand { get; set; }
        public string Car_No { get; set; }
        public string Register_Date { get; set; }
        public string Owner_Name { get; set; }
        public string Car_Type { get; set; }

        public string CNIC { get; set; }
        public Nullable<int> Car_Id { get; set; }
        public string Date { get; set; }
        public string Insurance_Type { get; set; }
        public string Card_No { get; set; }
        public string Expire_Date { get; set; }
        public string CVV { get; set; }
        public Nullable<int> Plan_Id { get; set; }
    }
}