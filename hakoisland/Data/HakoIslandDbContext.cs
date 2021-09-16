using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace hakoisland.Data
{
    public partial class HakoIslandDbContext : DbContext
    {
        public HakoIslandDbContext()
        {
        }

        public HakoIslandDbContext(DbContextOptions<HakoIslandDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Boat> Boat { get; set; }
        public virtual DbSet<Citys> Citys { get; set; }
        public virtual DbSet<EfmigrationsHistory> EfmigrationsHistory { get; set; }
        public virtual DbSet<Facility> Facility { get; set; }
        public virtual DbSet<Fleet> Fleet { get; set; }
        public virtual DbSet<History> History { get; set; }
        public virtual DbSet<Island> Island { get; set; }
        public virtual DbSet<IslandOpt> IslandOpt { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<Ocean> Ocean { get; set; }
        public virtual DbSet<Password> Password { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Boat>(entity =>
            {
                entity.ToTable("boat");

                entity.Property(e => e.BoatId)
                    .HasColumnName("BoatID")
                    .HasColumnType("int(10) unsigned")
                    .HasComment("船隻ID");

                entity.Property(e => e.BoatLoad)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("載重(貨倉)");

                entity.Property(e => e.Deep)
                    .HasColumnType("int(11)")
                    .HasComment("深度");

                entity.Property(e => e.FleetId)
                    .HasColumnName("FleetID")
                    .HasColumnType("int(10) unsigned")
                    .HasComment("艦隊ID");

                entity.Property(e => e.Hp)
                    .HasColumnName("HP")
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'3'")
                    .HasComment("耐久");

                entity.Property(e => e.IslandId)
                    .HasColumnName("IslandID")
                    .HasColumnType("int(10) unsigned")
                    .HasComment("所有人ID");

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .HasColumnType("int(10) unsigned")
                    .HasComment("位置ID");

                entity.Property(e => e.MaxSpeed)
                    .HasColumnType("int(10) unsigned")
                    .HasDefaultValueSql("'1'")
                    .HasComment("最大速度");

                entity.Property(e => e.Type)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("船隻型態");

                entity.Property(e => e.Vector)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("向量");
            });

            modelBuilder.Entity<Citys>(entity =>
            {
                entity.HasKey(e => e.CityId)
                    .HasName("PRIMARY");

                entity.ToTable("citys");

                entity.Property(e => e.CityId)
                    .HasColumnName("CityID")
                    .HasColumnType("int(11) unsigned")
                    .HasComment("城市ID");

                entity.Property(e => e.IslandId)
                    .HasColumnName("IslandID")
                    .HasColumnType("int(11) unsigned")
                    .HasComment("所有人ID");

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .HasColumnType("int(11) unsigned")
                    .HasComment("位置ID");

                entity.Property(e => e.Population)
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("'1'")
                    .HasComment("人口數量");

                entity.Property(e => e.Type)
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("'1'")
                    .HasComment("都市型態");
            });

            modelBuilder.Entity<EfmigrationsHistory>(entity =>
            {
                entity.HasKey(e => e.MigrationId)
                    .HasName("PRIMARY");

                entity.ToTable("__EFMigrationsHistory");

                entity.Property(e => e.MigrationId)
                    .HasColumnType("varchar(95)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.ProductVersion)
                    .IsRequired()
                    .HasColumnType("varchar(32)")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<Facility>(entity =>
            {
                entity.ToTable("facility");

                entity.Property(e => e.FacilityId)
                    .HasColumnName("FacilityID")
                    .HasColumnType("int(10) unsigned")
                    .HasComment("設施ID");

                entity.Property(e => e.Employee)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("職員數量");

                entity.Property(e => e.Exp)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("累積經驗");

                entity.Property(e => e.IslandId)
                    .HasColumnName("IslandID")
                    .HasColumnType("int(10) unsigned")
                    .HasComment("所有人ID");

                entity.Property(e => e.Level)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("設施等級");

                entity.Property(e => e.LoadingPower)
                    .HasColumnType("int(11)")
                    .HasComment("消耗電力");

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .HasColumnType("int(10) unsigned")
                    .HasComment("位置ID");

                entity.Property(e => e.Stock)
                    .HasColumnType("int(11) unsigned")
                    .HasComment("設施庫存");

                entity.Property(e => e.SupportPower)
                    .HasColumnType("int(11)")
                    .HasComment("消耗電力");

                entity.Property(e => e.Type)
                    .HasColumnType("int(11) unsigned")
                    .HasComment("設施型態");
            });

            modelBuilder.Entity<Fleet>(entity =>
            {
                entity.ToTable("fleet");

                entity.Property(e => e.FleetId)
                    .HasColumnName("FleetID")
                    .HasColumnType("int(10) unsigned")
                    .HasComment("艦隊ID");

                entity.Property(e => e.FleetNumber)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("編組編號");

                entity.Property(e => e.IslandId)
                    .HasColumnName("IslandID")
                    .HasColumnType("int(10) unsigned")
                    .HasComment("所有人ID");

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .HasColumnType("int(10) unsigned")
                    .HasComment("旗艦位置ID");

                entity.Property(e => e.TargetLocationId)
                    .HasColumnName("TargetLocationID")
                    .HasColumnType("int(10) unsigned")
                    .HasComment("目標位置ID");
            });

            modelBuilder.Entity<History>(entity =>
            {
                entity.ToTable("history");

                entity.Property(e => e.HistoryId)
                    .HasColumnName("HistoryID")
                    .HasColumnType("int(11)")
                    .HasComment("歷史事件ID");

                entity.Property(e => e.Infomation)
                    .IsRequired()
                    .HasColumnType("text")
                    .HasComment("事件資訊")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.Time)
                    .HasColumnType("int(11)")
                    .HasComment("事件發生回合");

                entity.Property(e => e.Uid)
                    .HasColumnName("UID")
                    .HasColumnType("int(11)")
                    .HasComment("島嶼ID");
            });

            modelBuilder.Entity<Island>(entity =>
            {
                entity.ToTable("island");

                entity.HasIndex(e => e.IslandId)
                    .HasName("UID");

                entity.Property(e => e.IslandId)
                    .HasColumnName("IslandID")
                    .HasColumnType("int(11)")
                    .HasComment("島嶼ID");

                entity.Property(e => e.AccumulatedTourists)
                    .HasColumnType("int(11) unsigned")
                    .HasComment(" 累積觀光客");

                entity.Property(e => e.Foods)
                    .HasColumnType("int(11) unsigned")
                    .HasDefaultValueSql("'5000'")
                    .HasComment("食料");

                entity.Property(e => e.Funds)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("'2000'")
                    .HasComment("資金");

                entity.Property(e => e.Name)
                    .HasColumnType("text")
                    .HasComment("島嶼名稱")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");

                entity.Property(e => e.UserName)
                    .HasColumnType("text")
                    .HasComment("玩家名稱")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            modelBuilder.Entity<IslandOpt>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("island_opt");

                entity.Property(e => e.CommandId)
                    .HasColumnName("CommandID")
                    .HasColumnType("int(11)")
                    .HasComment("指令ID(指令清單編號)");

                entity.Property(e => e.ExcutorId)
                    .HasColumnName("ExcutorID")
                    .HasColumnType("int(11)")
                    .HasComment("執行者ID");

                entity.Property(e => e.IslandId)
                    .HasColumnName("IslandID")
                    .HasColumnType("int(11)")
                    .HasComment("島嶼ID");

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .HasColumnType("int(11)")
                    .HasComment("位置ID");

                entity.Property(e => e.Number)
                    .HasColumnType("int(11)")
                    .HasComment("數量");

                entity.Property(e => e.OptionId)
                    .HasColumnName("OptionID")
                    .HasColumnType("int(11)")
                    .HasComment("指令編號ID");

                entity.Property(e => e.Type)
                    .HasColumnType("int(11)")
                    .HasComment("指令種類");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("location");

                entity.Property(e => e.LocationId)
                    .HasColumnName("LocationID")
                    .HasColumnType("int(11) unsigned")
                    .HasComment("區塊ID");

                entity.Property(e => e.Pollution)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("污染指數");

                entity.Property(e => e.Uoid)
                    .HasColumnName("UOID")
                    .HasColumnType("int(11) unsigned")
                    .HasComment("島嶼ID/海域ID");

                entity.Property(e => e.X)
                    .HasColumnType("int(11) unsigned")
                    .HasComment("區塊座標X");

                entity.Property(e => e.Y)
                    .HasColumnType("int(11) unsigned")
                    .HasComment("區塊座標Y");
            });

            modelBuilder.Entity<Ocean>(entity =>
            {
                entity.ToTable("ocean");

                entity.Property(e => e.OceanId)
                    .HasColumnName("OceanID")
                    .HasColumnType("int(11) unsigned")
                    .HasComment("海域ID");

                entity.Property(e => e.Info)
                    .HasColumnName("info")
                    .HasColumnType("int(11)")
                    .HasComment("此欄位當前無意義");
            });

            modelBuilder.Entity<Password>(entity =>
            {
                entity.HasKey(e => e.IslandId)
                    .HasName("PRIMARY");

                entity.ToTable("password");

                entity.HasIndex(e => e.IslandId)
                    .HasName("UID");

                entity.Property(e => e.IslandId)
                    .HasColumnName("IslandID")
                    .HasColumnType("int(11) unsigned")
                    .HasComment("島嶼ID");

                entity.Property(e => e.Password1)
                    .HasColumnName("Password")
                    .HasColumnType("text")
                    .HasComment("密碼")
                    .HasCharSet("utf8")
                    .HasCollation("utf8_unicode_ci");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
