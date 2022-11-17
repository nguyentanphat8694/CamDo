using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamDo.Db.MTable
{
    public class MInterest
    {
        public int Id { get; set; }
        public string ContractId { get; set; }
        public int StaffId { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public DateTime CreatedDate { get; set; }

        public MContract Contract { get; set; }
        public MStaff Staff { get; set; }
    }
}
