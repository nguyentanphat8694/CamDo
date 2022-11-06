using CamDo.Db;
using CamDo.Entity;
using CamDo.Entity.VModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CamDo.Business
{
    public class ContractServices
    {
        public VContract CreateContract(string customerName, int staffId, int cost, string description, bool isMachine)
        {
            if (string.IsNullOrEmpty(customerName) || string.IsNullOrEmpty(description) || staffId == 0 || cost == 0)
                return null;
            using (var context = new PrawnDbContext())
            {
                VContract contract = null;
                if (isMachine)
                {
                    var st = context.AppSettings.FirstOrDefault(x => string.Equals(x.Name, EAppSetting.NumberMachineId));
                    if (st == null)
                        return null;
                    var numStr = st.Value;
                    var numId = Int32.Parse(numStr) + 1;
                    st.Value = numId.ToString("0000");
                }
                else
                {

                }
                return contract;
            }
        }
    }
}
