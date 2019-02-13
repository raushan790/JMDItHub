using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using jmdbase.Models;

namespace jmdbase.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }

        public DbSet<jmdbase.Models.ApplicationUser> ApplicationUser { get; set; }

        public DbSet<jmdbase.Models.Bill> Bill { get; set; }

        public DbSet<jmdbase.Models.BillType> BillType { get; set; }

        public DbSet<jmdbase.Models.Branch> Branch { get; set; }

        public DbSet<jmdbase.Models.CashBank> CashBank { get; set; }

        public DbSet<jmdbase.Models.Currency> Currency { get; set; }

        public DbSet<jmdbase.Models.Customer> Customer { get; set; }
        public DbSet<jmdbase.Models.Client> Client { get; set; }


        public DbSet<jmdbase.Models.CustomerType> CustomerType { get; set; }

        public DbSet<jmdbase.Models.GoodsReceivedNote> GoodsReceivedNote { get; set; }

        public DbSet<jmdbase.Models.Invoice> Invoice { get; set; }

        public DbSet<jmdbase.Models.InvoiceType> InvoiceType { get; set; }

        public DbSet<jmdbase.Models.NumberSequence> NumberSequence { get; set; }

        public DbSet<jmdbase.Models.PaymentReceive> PaymentReceive { get; set; }

        public DbSet<jmdbase.Models.PaymentType> PaymentType { get; set; }

        public DbSet<jmdbase.Models.PaymentVoucher> PaymentVoucher { get; set; }

        public DbSet<jmdbase.Models.Product> Product { get; set; }

        public DbSet<jmdbase.Models.ProductType> ProductType { get; set; }

        public DbSet<jmdbase.Models.PurchaseOrder> PurchaseOrder { get; set; }

        public DbSet<jmdbase.Models.PurchaseOrderLine> PurchaseOrderLine { get; set; }

        public DbSet<jmdbase.Models.PurchaseType> PurchaseType { get; set; }

        public DbSet<jmdbase.Models.SalesOrder> SalesOrder { get; set; }

        public DbSet<jmdbase.Models.SalesOrderLine> SalesOrderLine { get; set; }

        public DbSet<jmdbase.Models.SalesType> SalesType { get; set; }

        public DbSet<jmdbase.Models.Shipment> Shipment { get; set; }

        public DbSet<jmdbase.Models.ShipmentType> ShipmentType { get; set; }

        public DbSet<jmdbase.Models.UnitOfMeasure> UnitOfMeasure { get; set; }

        public DbSet<jmdbase.Models.Vendor> Vendor { get; set; }

        public DbSet<jmdbase.Models.VendorType> VendorType { get; set; }

        public DbSet<jmdbase.Models.Warehouse> Warehouse { get; set; }

        public DbSet<jmdbase.Models.UserProfile> UserProfile { get; set; }
    }
}
