//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication6.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class booking
    {
        public int booking_id { get; set; }
        public int user_id { get; set; }
        public int showing_id { get; set; }
        public string seat_number { get; set; }
        public Nullable<System.DateTime> booking_date { get; set; }
    }
}
