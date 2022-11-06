using CamDo.Db.MTable;
using CamDo.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CamDo.Db
{
    public class PrawnDbContext : DbContext
    {
        public DbSet<MAppSetting> AppSettings { get; set; }
        public DbSet<MContract> Contracts { get; set; }
        public DbSet<MExchange> Exchanges { get; set; }
        public DbSet<MInterest> Interests { get; set; }
        public DbSet<MInterestSettings> InterestSettings { get; set; }
        public DbSet<MLiquidation> Liquidations { get; set; }
        public DbSet<MLoss> Losses { get; set; }
        public DbSet<MMoneyCount> MoneyCounts { get; set; }
        public DbSet<MMoneyInOut> MoneyInOuts { get; set; }
        public DbSet<MRedeem> Redeems { get; set; }
        public DbSet<MStaff> Staffs { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlite($"Filename={DDatabase.DatabaseName}",
                    option =>
                    {
                        option.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
                    });
                base.OnConfiguring(optionsBuilder);
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Config Tables
            modelBuilder.Entity<MStaff>().ToTable("Staff", "main");
            modelBuilder.Entity<MStaff>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Name).IsRequired(true);
                entity.Property(x => x.IsDeleted).HasDefaultValue(false);
            });

            modelBuilder.Entity<MContract>().ToTable("Contract", "main");
            modelBuilder.Entity<MContract>(entity => 
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.CustomerName).IsRequired(true);
                entity.Property(x => x.Cost).IsRequired(true);
                entity.Property(x => x.Description).IsRequired(true);
                entity.Property(x => x.IsRedeem).IsRequired(true).HasDefaultValue(false);
                entity.Property(x => x.IsLiquidation).IsRequired(true).HasDefaultValue(false);
                entity.Property(x => x.IsLoss).IsRequired(true).HasDefaultValue(false);
                entity.Property(x => x.IsPrint).HasDefaultValue(false);
                entity.Property(x => x.IsMachine).HasDefaultValue(false);
                entity.Property(x => x.CreatedDate).IsRequired(true).HasDefaultValue(DateTime.UtcNow);
                entity.HasOne<MRedeem>(x => x.Redeem).WithOne(x => x.Contract).HasForeignKey<MRedeem>(x => x.ContractId);
                entity.HasOne<MLoss>(x => x.Loss).WithOne(x => x.Contract).HasForeignKey<MLoss>(x => x.ContractId);
                entity.HasOne<MLiquidation>(x => x.Liquidation).WithOne(x => x.Contract).HasForeignKey<MLiquidation>(x => x.ContractId);
                entity.HasOne(x => x.Staff).WithMany(x => x.Contracts).HasForeignKey(x => x.StaffId).IsRequired(true);
                entity.HasIndex(x => x.CreatedDate);
            });

            modelBuilder.Entity<MInterest>().ToTable("Interest", "main");
            modelBuilder.Entity<MInterest>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.FromDate).IsRequired(true);
                entity.Property(x => x.ToDate).IsRequired(true);
                entity.Property(x => x.CreatedDate).IsRequired(true).HasDefaultValue(DateTime.UtcNow);
                entity.HasOne(x => x.Contract).WithMany(x => x.Interests).HasForeignKey(x => x.ContractId).IsRequired(true);
            });

            modelBuilder.Entity<MRedeem>().ToTable("Redeem", "main");
            modelBuilder.Entity<MRedeem>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.CreatedDate).IsRequired(true).HasDefaultValue(DateTime.UtcNow);
                entity.HasIndex(x => x.CreatedDate);

            });

            modelBuilder.Entity<MLoss>().ToTable("Loss", "main");
            modelBuilder.Entity<MLoss>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Name).IsRequired(true);
                entity.Property(x => x.NoId).IsRequired(true);
                entity.Property(x => x.Phone).IsRequired(true);
                entity.Property(x => x.CreatedDate).IsRequired(true).HasDefaultValue(DateTime.UtcNow);
                entity.HasIndex(x => x.CreatedDate);
            });

            modelBuilder.Entity<MLiquidation>().ToTable("Liquidation", "main");
            modelBuilder.Entity<MLiquidation>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Cost).IsRequired(true);
                entity.Property(x => x.CreatedDate).IsRequired(true).HasDefaultValue(DateTime.UtcNow);
            });

            modelBuilder.Entity<MMoneyInOut>().ToTable("MoneyInOut", "main");
            modelBuilder.Entity<MMoneyInOut>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Cost).IsRequired(true);
                entity.Property(x => x.Name).IsRequired(true);
                entity.Property(x => x.IsIn).IsRequired(true).HasDefaultValue(true);
                entity.Property(x => x.CreatedDate).IsRequired(true).HasDefaultValue(DateTime.UtcNow);
                entity.HasIndex(x => x.CreatedDate);
            });

            modelBuilder.Entity<MExchange>().ToTable("Exchange", "main");
            modelBuilder.Entity<MExchange>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.FromName).IsRequired(true);
                entity.Property(x => x.ToName).IsRequired(true);
                entity.Property(x => x.Rate).IsRequired(true);
                entity.Property(x => x.RateFor).IsRequired(true);
            });

            modelBuilder.Entity<MInterestSettings>().ToTable("InterestSetting", "main");
            modelBuilder.Entity<MInterestSettings>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.From).IsRequired(true);
                entity.Property(x => x.To).IsRequired(true);
                entity.Property(x => x.Rate).IsRequired(true);
                entity.Property(x => x.IsForMachine).IsRequired(true).HasDefaultValue(false);
                entity.Property(x => x.OperationFrom).IsRequired(true).HasDefaultValue(EMathOperation.LargerThanOrEqual.ToString());
                entity.Property(x => x.OperationTo).IsRequired(true).HasDefaultValue(EMathOperation.LessThan.ToString());
            });

            modelBuilder.Entity<MMoneyCount>().ToTable("MoneyCount", "main");
            modelBuilder.Entity<MMoneyCount>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.CreatedDate).IsRequired(true).HasDefaultValue(DateTime.UtcNow);
                entity.Property(x => x._500).IsRequired(true).HasDefaultValue(0);
                entity.Property(x => x._200).IsRequired(true).HasDefaultValue(0);
                entity.Property(x => x._100).IsRequired(true).HasDefaultValue(0);
                entity.Property(x => x._50).IsRequired(true).HasDefaultValue(0);
                entity.Property(x => x._20).IsRequired(true).HasDefaultValue(0);
                entity.Property(x => x._10).IsRequired(true).HasDefaultValue(0);
                entity.Property(x => x._5).IsRequired(true).HasDefaultValue(0);
                entity.Property(x => x._2).IsRequired(true).HasDefaultValue(0);
                entity.HasIndex(x => x.CreatedDate);
            });

            modelBuilder.Entity<MAppSetting>().ToTable("AppSetting", "main");
            modelBuilder.Entity<MAppSetting>(entity =>
            {
                entity.HasKey(x => x.Id);
                entity.Property(x => x.Name).IsRequired(true);
                entity.Property(x => x.Value).IsRequired(true);
            });
            #endregion

            base.OnModelCreating(modelBuilder);
        }
    }
}
