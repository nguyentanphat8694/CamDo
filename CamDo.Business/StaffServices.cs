using CamDo.Db;
using CamDo.Db.MTable;

namespace CamDo.Business
{
    public class StaffServices
    {
        public List<MStaff> GetAll()
        {
            using (var context = new PrawnDbContext())
            {
                return context.Staffs.ToList();
            }
        }
    }
}
