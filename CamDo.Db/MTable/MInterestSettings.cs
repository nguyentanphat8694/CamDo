using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamDo.Db.MTable
{
    public class MInterestSettings
    {
        public int Id { get; set; }
        public int From { get; set; }
        public int To { get; set; }
        public string OperationFrom {get; set;}
        public string OperationTo {get; set;}
        public int Rate { get; set; }
        public bool IsForMachine { get; set; }
        public string Note { get; set; }
    }
}
