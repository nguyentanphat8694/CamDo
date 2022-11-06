using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamDo.Db.MTable
{
    public class MLoss
    {
        public int Id { get; set; }
        public string ContractId { get; set; }
        public string Name { get; set; }
        public string NoId { get; set; }
        public string Phone { get; set; }
        public string Note { get; set; }
        public DateTime CreatedDate { get; set; }

        public MContract Contract { get; set; }
    }
}
