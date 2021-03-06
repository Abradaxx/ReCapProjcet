using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.FrameworkDal
{
    public class ReCapProjectContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Hangi veritabanı ve tabloyu kullancagımızı tanımladık
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=ReCapProject;Trusted_Connection=true");
        }
        public DbSet <Car> Cars  { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Rental> Rentals { get; set; }
        public DbSet<CarImage> CarImages { get; set; }

        //Veritabanındaki tablolarla neslerimizi ilişkilendirdik.
      
    }
}
//Yaptıkların

/*concrete leri oluşturdun
 * database de tablolar oluşturdun
 * dal kısmında efleri ve interface leri yaptın
 * son olarak burada veri tabanı ile ilişkilendirdin
 */