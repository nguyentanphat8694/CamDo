using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamDo.Db.MTable
{
    public class MMoneyInOut
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int CreatedDate { get; set; }
        public bool IsIn { get; set; }
    }
}
