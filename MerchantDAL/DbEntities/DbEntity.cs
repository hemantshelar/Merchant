using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DbEntities
{
    public abstract class DbEntity
    {
        public DateTime? date_created { get; set; }
        public DateTime? date_modified { get; set; }
    }
}
