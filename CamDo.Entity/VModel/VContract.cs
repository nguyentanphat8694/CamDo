using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamDo.Entity.VModel
{
    public class VContract
    {
        public string Id { get; set; }
        public string CustomerName { get; set; }
        public string StaffName { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsPrint { get; set; }
        public bool IsRedeem { get; set; }
        public bool IsLiquidation { get; set; }
        public bool IsLoss { get; set; }
        public bool IsMachine { get; set; }
    }
}
