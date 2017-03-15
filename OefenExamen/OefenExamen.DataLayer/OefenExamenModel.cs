
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OefenExamen.DomainClasses;

namespace OefenExamen.DataLayer
{
    public class OefenExamenModel : DbContext
    {
        public OefenExamenModel()
            : base("name=OefenExamenModel")
        {
        }

        public DbSet<Categories> Categories { get; set; }
        public DbSet<Customers> Customers { get; set; }
        public DbSet<Invoices> Invoices { get; set; }
        public DbSet<LineItems> LineItems { get; set; }
        public DbSet<Products> Products { get; set; }
        public DbSet<States> States { get; set; }
        public DbSet<InvoiceData> InvoiceData { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Categories>()
                .Property(e => e.CategoryID)
                .IsUnicode(false);

            modelBuilder.Entity<Categories>()
                .Property(e => e.ShortName)
                .IsUnicode(false);

            modelBuilder.Entity<Categories>()
                .Property(e => e.LongName)
                .IsUnicode(false);

            modelBuilder.Entity<Categories>()
                .HasMany(e => e.Products)
                .WithRequired(e => e.Categories)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.State)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.ZipCode)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .Property(e => e.PhoneNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Customers>()
                .HasMany(e => e.Invoices)
                .WithRequired(e => e.Customers)
                .HasForeignKey(e => e.CustEmail)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.CustEmail)
                .IsUnicode(false);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.Subtotal)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.ShipMethod)
                .IsUnicode(false);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.Shipping)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.SalesTax)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.Total)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.CreditCardType)
                .IsUnicode(false);

            modelBuilder.Entity<Invoices>()
                .Property(e => e.CardNumber)
                .IsUnicode(false);

            modelBuilder.Entity<Invoices>()
                .HasMany(e => e.LineItems)
                .WithRequired(e => e.Invoices)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<LineItems>()
                .Property(e => e.ProductID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<LineItems>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<LineItems>()
                .Property(e => e.Extension)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Products>()
                .Property(e => e.ProductID)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.ShortDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.LongDescription)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.CategoryID)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.ImageFile)
                .IsUnicode(false);

            modelBuilder.Entity<Products>()
                .Property(e => e.UnitPrice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Products>()
                .HasMany(e => e.LineItems)
                .WithRequired(e => e.Products)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<States>()
                .Property(e => e.StateCode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<States>()
                .Property(e => e.StateName)
                .IsUnicode(false);

            modelBuilder.Entity<States>()
                .HasMany(e => e.Customers)
                .WithRequired(e => e.States)
                .HasForeignKey(e => e.State)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<InvoiceData>()
                .Property(e => e.SalesTax)
                .HasPrecision(19, 4);
        }
    }
}
