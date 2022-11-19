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
        public List<string> ListLetters = new List<string> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
        
        private string GetIDContract(bool isMachine)
        {
            using (var context = new PrawnDbContext())
            {
                var lastId = "0000";
                if (isMachine)
                {
                    var setting = context.AppSettings.FirstOrDefault(x => string.Equals(x.Name, EAppSetting.NumberMachineId.ToString()));
                    if (setting != null)
                        lastId = setting.Value;
                    var newId = Int32.Parse(lastId) + 1;
                    lastId = newId.ToString("0000");
                }
                else
                {
                    var settingLetter = context.AppSettings.FirstOrDefault(x => string.Equals(x.Name, EAppSetting.KeyStringId.ToString()));
                    var settingNumber = context.AppSettings.FirstOrDefault(x => string.Equals(x.Name, EAppSetting.KeyNumberId.ToString()));
                    if (settingLetter != null && settingNumber != null)
                    {
                        var num = Int32.Parse(settingNumber.Value) + 1;
                        if (num > 999)
                        {
                            var letArr = settingLetter.Value.ToCharArray();
                            var curIdx = letArr.Length - 1;
                            var isContinue = true;
                            while (isContinue)
                            {
                                var curChar = letArr[curIdx].ToString();
                                var noAlphabet = ListLetters.Count;
                                var alphabetIdx = ListLetters.IndexOf(curChar);
                                if (curIdx < 0)
                                {
                                    lastId = ListLetters[0];
                                    foreach (var i in letArr)
                                        lastId += ListLetters[0];
                                    break;
                                }
                                else
                                {
                                    if (alphabetIdx >= noAlphabet - 1)
                                        curIdx -= 1;
                                    else
                                    {
                                        lastId = "";
                                        for (var i = 0; i < letArr.Length; i++)
                                        {
                                            if (i == curIdx)
                                                lastId += ListLetters[alphabetIdx + 1];
                                            else if (i < curIdx)
                                                lastId += letArr[i];
                                            else
                                                lastId += ListLetters[0];
                                        }
                                        break;
                                    }
                                }
                            }
                        }
                        else
                            lastId = settingNumber.Value + num.ToString("000");
                    }
                }
                return lastId;
            }
        }

        public async Task<VContract> GetInitContractForm()
        {
            var keyPrice = "610";
            var priceData = DatabaseLocal.GetInstance().PrawnPrice.FirstOrDefault(x => string.Equals(x.Key, keyPrice));
            var price = string.IsNullOrEmpty(priceData.Key) ? 0 : priceData.Value;
            var idContract = GetIDContract(false);
            var newContract = new VContract()
            {
                Id = idContract,
                CreatedDate = DateTime.Now,
                TotalWeight = 0,
                NotGoldWeightCost = 0,
                TypeGold = keyPrice,
                PriceUnit = price,
                Cost = 0,
            };
            return newContract;
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
