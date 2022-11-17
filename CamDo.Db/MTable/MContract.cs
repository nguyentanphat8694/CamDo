using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamDo.Db.MTable
{
    public class MContract
    {
        public MContract() 
        {
            Interests = new HashSet<MInterest>();
        }
        public string Id { get; set; }
        public string CustomerName { get; set; }
        public int StaffId { get; set; }
        public int Cost { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool IsPrint { get; set; }
        public bool IsRedeem { get; set; }
        public bool IsLiquidation { get; set; }
        public bool IsLoss { get; set; }
        public bool IsMachine { get; set; }
        public string TypeGold { get; set; }
        public decimal? TotalWeight { get; set; }
        public decimal? NotGoldWeight { get; set; }

        public MStaff Staff { get; set; }
        public MRedeem Redeem { get; set; }
        public MLoss Loss { get; set; }
        public MLiquidation Liquidation { get; set; }
        public ICollection<MInterest> Interests { get; set; }
    }
}
