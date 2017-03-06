using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Merchant
    {
        public string _id { get; set; }
        public string display_name { get; set; }
        public string registered_name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string web_url { get; set; }
        public int merchant_id { get; set; }
        public Address address { get; set; }
        public DateTime? date_modified { get; set; }
        public DateTime? date_created { get; set; }
        public string status { get; set; }
        public string logo { get; set; }
    }
}
