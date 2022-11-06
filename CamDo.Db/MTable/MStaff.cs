using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamDo.Db.MTable
{
    public class MStaff
    {
        public MStaff()
        {
            Contracts = new HashSet<MContract>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<MContract> Contracts { get; set; }
    }
}
