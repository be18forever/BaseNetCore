using common.Interface;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace common.Core
{
    public  class XDbContext:DbContext,IXDbContext
    {

        public XDbContext()
        {

        }
        public XDbContext(DbContextOptions<XDbContext> options) : base(options)
        {


        }

        public override int SaveChanges()
        {
            return base.SaveChanges(true);
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("server=.;database=ConCard;uid=sa;pwd=123123;");
            }
        }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

        //    modelBuilder.Entity<Admin>(entity =>
        //    {
        //        entity.Property(e => e.PassWord).HasMaxLength(50);

        //        entity.Property(e => e.UserId).HasMaxLength(50);
        //    });

        //    modelBuilder.Entity<User>(entity =>
        //    {
        //        entity.Property(e => e.Name).HasMaxLength(50);

        //        entity.Property(e => e.Phone).HasMaxLength(50);
        //    });
        //}
    }
}
