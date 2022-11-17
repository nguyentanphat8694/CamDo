using CamDo.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CamDo.Db
{
    public class DatabaseServices
    {
        public async Task CheckAndUpdateDatabase()
        {
            var dbName = DDatabase.DatabaseName;
            using (var context = new PrawnDbContext())
            {
                if (!File.Exists(dbName))
                {
                    await context.Database.EnsureCreatedAsync();
                    CreateAppSetting(context);
                    await context.SaveChangesAsync();
                }
            }
        }

        public PrawnDbContext CreateAppSetting(PrawnDbContext context)
        {
            context.AppSettings.Add(new MTable.MAppSetting
            {
                Id = 1,
                Name = EAppSetting.AdminPassword.ToString(),
                Value = "admin"
            });
            context.AppSettings.Add(new MTable.MAppSetting
            {
                Id = 2,
                Name = EAppSetting.KeyStringId.ToString(),
                Value = "A"
            });
            context.AppSettings.Add(new MTable.MAppSetting
            {
                Id = 3,
                Name = EAppSetting.KeyNumberId.ToString(),
                Value = "000"
            });
            context.AppSettings.Add(new MTable.MAppSetting
            {
                Id = 4,
                Name = EAppSetting.NumberMachineId.ToString(),
                Value = "0000"
            });
            context.PrawnPrices.Add(new MTable.MPrawnPrice
            {
                Id = 1,
                Name = "610",
                Price = 2700000
            });
            context.PrawnPrices.Add(new MTable.MPrawnPrice
            {
                Id = 2,
                Name = "9999",
                Price = 4500000
            });
            context.PrawnPrices.Add(new MTable.MPrawnPrice
            {
                Id = 3,
                Name = "999",
                Price = 4500000
            });
            context.PrawnPrices.Add(new MTable.MPrawnPrice
            {
                Id = 4,
                Name = "980",
                Price = 4500000
            });
            return context;
        }
    }
}
