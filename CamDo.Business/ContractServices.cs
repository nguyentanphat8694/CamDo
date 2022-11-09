using CamDo.Db;
using CamDo.Db.MTable;
using CamDo.Entity;
using CamDo.Entity.VModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public async Task<bool> CreateContract(VContract contract)
        {
            var c = new MContract()
            {
                Id = contract.Id,
                CustomerName = contract.CustomerName,
                StaffId = StaffServices.GetStaffIdByName(contract.StaffName),
                Cost = contract.Cost,
                Description = contract.Description,
                CreatedDate = DateTime.Now,
                IsPrint = false,
                IsRedeem = false,
                IsLiquidation = false,
                IsLoss = false,
                IsMachine = contract.IsMachine,
            };
            using (var context = new PrawnDbContext())
            {
                context.Contracts.Add(c);
                await context.SaveChangesAsync();
                return true;
            }
        }
    }
}
