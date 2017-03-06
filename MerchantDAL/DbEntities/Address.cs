using DAL.DbEntities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MerchantDAL.DbEntities
{
    public class Address : DbEntity
    {
        public int Id { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string postcode { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public string UserId { get; set; }
    }
}
