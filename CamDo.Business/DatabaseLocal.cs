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

        public DatabaseLocal()
        {
            var staffServices = new StaffServices();
            Staffs = staffServices.GetAll();
        }

        public List<MStaff> Staffs { get; set; }
    }
}
