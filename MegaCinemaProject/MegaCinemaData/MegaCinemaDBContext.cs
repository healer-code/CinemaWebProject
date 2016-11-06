using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Data.Entity.Validation;
using MegaCinemaModel.Models;

namespace MegaCinemaData
{
    public class MegaCinemaDBContext:DbContext
    {
        public MegaCinemaDBContext():base("MegaCinemaDB")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                string errorMessages = string.Join("; ", ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => x.ErrorMessage));
                throw new DbEntityValidationException(errorMessages);
            }
        }
        
        //Entity list
        public DbSet<Status> Statuss { get; set; }
        public DbSet<FilmRating> FilmRatings { get; set; }
        public DbSet<FilmCategory> FilmCategories { get; set; }
        public DbSet<FilmFormat> FilmFormats { get; set; }
        public DbSet<DetailFormat> DetailFormats { get; set; }
        public DbSet<DetailCategory> DetailCategories { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Regency> Regencys { get; set; }
        public DbSet<Staff> Staffs { get; set; }

        //Assign attribute
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
