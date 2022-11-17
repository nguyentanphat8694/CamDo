using CamDo.Db;
using CamDo.Db.MTable;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamDo.Business
{
    public class DatabaseLocal
    {
        private static DatabaseLocal _instance;
        public static DatabaseLocal GetInstance()
        {
            if (_instance == null)
                _instance = new DatabaseLocal();
            return _instance;
        }

        private List<MStaff> staffs;
        public List<MStaff> Staffs
        {
            get
            {
                if (staffs == null)
                {
                    using (var context = new PrawnDbContext())
                        staffs = context.Staffs.ToList();
                }
                return staffs;
            }
            set
            {
                staffs = value;
            }
        }

        private List<KeyValuePair<string, int>> prawnPrice;
        public List<KeyValuePair<string, int>> PrawnPrice
        {
            get
            {
                if (prawnPrice == null)
                {
                    using (var context = new PrawnDbContext())
                        prawnPrice = context.PrawnPrices.Select(x => new KeyValuePair<string, int> (x.Name, x.Price)).ToList();
                }
                return prawnPrice;
            }
            set
            {
                prawnPrice = value;
            }
        }
    }
}
