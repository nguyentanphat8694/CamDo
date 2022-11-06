using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamDo.Db.MTable
{
    public class MExchange
    {
        public int Id { get; set; }
        public string FromName { get; set; }
        public string ToName { get; set; }  
        public int Rate { get; set; }
        public int RateFor { get; set; }
    }
}
