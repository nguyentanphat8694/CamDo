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

        public static int GetStaffIdByName(string name)
        {
            var staff = DatabaseLocal.GetInstance().Staffs.FirstOrDefault(s => s.Name == name);
            if (staff != null)
                return staff.Id;
            return 0;
        }
    }
}
