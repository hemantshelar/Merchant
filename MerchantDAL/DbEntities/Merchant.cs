using DAL.DbEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantDAL.DbEntities
{
    public class Merchant : DbEntity
    {
        [Key]
        public string _id { get; set; }
        public string display_name { get; set; }       
        public string email { get; set; }
        public string logo { get; set; }
        public string phone { get; set; }
        public string registered_name { get; set; }
        public string status { get; set; }

    }
}
