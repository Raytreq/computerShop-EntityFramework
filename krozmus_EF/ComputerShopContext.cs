using krozmus_EF.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace krozmus_EF
{
    public class ComputerShopContext : DbContext
    {
        public DbSet<Computer> Computers { get; set; }
        public DbSet<CPU> CPUS { get; set; }
        public DbSet<GPU> GPUS { get; set; }
        public DbSet<Disk> Disks { get; set; }
        public DbSet<RAM> RAMMemories { get; set; }
        public DbSet<Motherboard> Motherboards { get; set; }
        public DbSet<PSU> PSUS{ get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=ComputerShop;Integrated Security=True;");
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CPU>()
                .HasKey(x => x.CPUID);
            modelBuilder.Entity<GPU>()
                .HasKey(x => x.GPUID);
            modelBuilder.Entity<Disk>()
                .HasKey(x => x.DiskID);
            modelBuilder.Entity<RAM>()
                .HasKey(x => x.RAMID);
            modelBuilder.Entity<Motherboard>()
                .HasKey(x => x.MotherboardID);
            modelBuilder.Entity<PSU>()
                .HasKey(x => x.PSUID);
            modelBuilder.Entity<Computer>()
                .HasKey(x => x.ComputerID);


            modelBuilder.Entity<Computer>()
                .HasOne(x => x.Processor)
                .WithMany(y => y.Computers)
                .HasForeignKey(x => x.CPUID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Computer>()
                .HasOne(x => x.GraphicsCard)
                .WithMany(y => y.Computers)
                .HasForeignKey(x => x.GraphicsCardID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Computer>()
                .HasOne(x => x.Disk)
                .WithMany(y => y.Computers)
                .HasForeignKey(x => x.DiskID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Computer>()
                .HasOne(x => x.RAMMemory)
                .WithMany(y => y.Computers)
                .HasForeignKey(x => x.RAMMemoryID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Computer>()
                .HasOne(x => x.Motherboard)
                .WithMany(y => y.Computers)
                .HasForeignKey(x => x.MotherboardID)
                .OnDelete(DeleteBehavior.ClientSetNull);

            modelBuilder.Entity<Computer>()
                .HasOne(x => x.PowerSupply)
                .WithMany(y => y.Computers)
                .HasForeignKey(x => x.PowerSupplyID)
                .OnDelete(DeleteBehavior.ClientSetNull);
        }
    }
}
                
