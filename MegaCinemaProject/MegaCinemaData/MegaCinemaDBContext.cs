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


        //Assign attribute
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            
        }
    }
}
