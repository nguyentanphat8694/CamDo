﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamDo.Db.MTable
{
    public class MLiquidation
    {
        public int Id { get; set; }
        public string ContractId { get; set; }
        public int Cost { get; set; }
        public string Note { get; set; }
        public DateTime CreatedDate { get; set; }

        public MContract Contract { get; set; }
    }
}
