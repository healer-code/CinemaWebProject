using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Data.Entity.Validation;
using MegaCinemaModel.Models;
using Microsoft.AspNet.Identity.EntityFramework;

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
        public DbSet<FilmCategory> FilmCategories { get; set; }
        public DbSet<FilmFormat> FilmFormats { get; set; }
        public DbSet<Film> Films { get; set; }
        public DbSet<FilmRating> FilmRatings { get; set; }
        public DbSet<DetailFormat> DetailFormats { get; set; }
        public DbSet<DetailCategory> DetailCategories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<AccountType> AccountTypes { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Regency> Regencies { get; set; }
        public DbSet<Cinema> Cinemas { get; set; }
        public DbSet<CinemaFeature> CinemaFeatures { get; set; }
        public DbSet<FeatureDetail> FeatureDetails { get; set; }
        public DbSet<FoodList> FoodLists { get; set; }
        public DbSet<SeatType> SeatTypes { get; set; }
        public DbSet<RoomFilm> RoomFilms { get; set; }
        public DbSet<SeatList> SeatLists { get; set; }
        public DbSet<TimeSession> TimeSessions { get; set; }
        public DbSet<SeatMaintenance> SeatMaintenances { get; set; }
        public DbSet<FilmSession> FilmSessions { get; set; }
        public DbSet<TicketCategory> TicketCategories { get; set; }
        public DbSet<BookingTicket> BookingTickets { get; set; }
        public DbSet<TicketDetail> TicketDetails { get; set; }
        public DbSet<TicketCombo> TicketCombos { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<PromotionCine> PromotionCines { get; set; }
        public DbSet<Parameter> Parameters { get; set; }

        //Assign attribute
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Asp.net identity
            modelBuilder.Entity<IdentityUserRole>().HasKey(i => new { i.UserId, i.RoleId }).ToTable("ApplicationUserRoles");
            modelBuilder.Entity<IdentityUserLogin>().HasKey(i => i.UserId).ToTable("ApplicationUserLogins");

            //status
            modelBuilder.Entity<Status>()
                .HasMany(e => e.Films)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Customers)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Staffs)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Cinemas)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.FoodLists)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.SeatTypes)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.RoomFilms)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.SeatLists)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.TimeSessions)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.SeatMaintenances)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.FilmSessions)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.TicketCategories)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.BookingTickets)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.TicketDetails)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.TicketCombos)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.Promotions)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Status>()
                .HasMany(e => e.PromotionCines)
                .WithRequired(e => e.Status)
                .WillCascadeOnDelete(false);

            //Film categories

            //Film Format
            modelBuilder.Entity<FilmFormat>()
                .HasMany(e => e.DetailFormats)
                .WithRequired(e => e.FilmFormat)
                .WillCascadeOnDelete(false);

            //Film
            modelBuilder.Entity<Film>()
                .HasMany(e => e.DetailCategories)
                .WithRequired(e => e.Film)
                .WillCascadeOnDelete(false);

            //Film rating
            modelBuilder.Entity<FilmRating>()
                .HasMany(e => e.Films)
                .WithRequired(e => e.FilmRating)
                .WillCascadeOnDelete(false);

            //Detail format
            //Detail Category

            //Customer 

            //Account type

            //Staff

            //Regency

            //Cinema

            //Cinema Feature

            //Feature detail

            //Food Lists

            //Seat Type

            //Room Film

            //Seat List

            //Time Session

            //Seat Maintenance

            //Film session

            //Ticket Categories

            //Booking ticket

            //Ticket Detail

            //Ticket Combo

            //Promotion 

            //Promotion Cinema

            //Parameters
        }
    }
}
