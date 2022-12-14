using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessEntities
{
    public class customer
    {
        public long customer_details_id { get; set;}
        public Guid customer_id { get; set; }
        public string full_name { get; set; }
        public string email_id { get; set; }
        public string contact_number { get; set; }
        public string address { get; set; }
        public string land_mark { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string pin_code { get; set; }
        public string message { get; set; }
        public bool is_active { get; set; }
        public DateTime created_date { get; set; }
        public DateTime updated_date { get; set; }

        public string customer_name { get; set; }
        public string password { get; set; }
        public string newpassword { get; set; }
        public string login_type { get; set; }
    }
}
