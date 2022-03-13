using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Ontaz.Dal.DBOntaz.Model;

namespace Ontaz.Dal.DBOntaz.Context
{
    public partial class APIContext : DbContext
    {
        public APIContext()
        {
        }

        public APIContext(DbContextOptions<APIContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Advertising> Advertisings { get; set; } = null!;
        public virtual DbSet<Category> Categories { get; set; } = null!;
        public virtual DbSet<City> Cities { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ServiceCommerce> ServiceCommerces { get; set; } = null!;
        public virtual DbSet<State> States { get; set; } = null!;
        public virtual DbSet<Subscription> Subscriptions { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<VwService> VwServices { get; set; } = null!;
        public virtual DbSet<VwServicesDetail> VwServicesDetails { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=experimentserver.database.windows.net;Initial Catalog=ontaz;Persist Security Info=False;User ID=ontaz;Password=0827199Ab;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Advertising>(entity =>
            {
                entity.HasKey(e => e.IdAdvertising)
                    .HasName("pk_id_advertising");

                entity.ToTable("advertising");

                entity.Property(e => e.IdAdvertising).HasColumnName("id_advertising");

                entity.Property(e => e.DateEnd)
                    .HasColumnType("datetime")
                    .HasColumnName("date_end");

                entity.Property(e => e.DateStart)
                    .HasColumnType("datetime")
                    .HasColumnName("date_start");

                entity.Property(e => e.IdService).HasColumnName("id_service");

                entity.HasOne(d => d.IdServiceNavigation)
                    .WithMany(p => p.Advertisings)
                    .HasForeignKey(d => d.IdService)
                    .HasConstraintName("fk_advertising_service");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasKey(e => e.IdCategory)
                    .HasName("pk_id_category");

                entity.ToTable("category");

                entity.Property(e => e.IdCategory).HasColumnName("id_category");

                entity.Property(e => e.NameCartegory)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name_cartegory");

                entity.Property(e => e.RegDeleted)
                    .HasColumnName("reg_deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UrlCategory)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("url_category");
            });

            modelBuilder.Entity<City>(entity =>
            {
                entity.HasKey(e => e.IdCity)
                    .HasName("pk_id_city");

                entity.ToTable("city");

                entity.Property(e => e.IdCity).HasColumnName("id_city");

                entity.Property(e => e.IdState).HasColumnName("id_state");

                entity.Property(e => e.NameCity)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name_city");

                entity.HasOne(d => d.IdStateNavigation)
                    .WithMany(p => p.Cities)
                    .HasForeignKey(d => d.IdState)
                    .HasConstraintName("fk_state_city");
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.HasKey(e => e.IdCountry)
                    .HasName("pk_id_country");

                entity.ToTable("country");

                entity.Property(e => e.IdCountry).HasColumnName("id_country");

                entity.Property(e => e.NameCountry)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name_country");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.HasKey(e => e.IdPayment)
                    .HasName("pk_id_payment");

                entity.ToTable("payment");

                entity.Property(e => e.IdPayment).HasColumnName("id_payment");

                entity.Property(e => e.IdService).HasColumnName("id_service");

                entity.Property(e => e.IdSubscription).HasColumnName("id_subscription");

                entity.HasOne(d => d.IdServiceNavigation)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.IdService)
                    .HasConstraintName("fk_payment_service");

                entity.HasOne(d => d.IdSubscriptionNavigation)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.IdSubscription)
                    .HasConstraintName("fk_payment_product");
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.HasKey(e => e.IdProduct)
                    .HasName("pk_id_product");

                entity.ToTable("product");

                entity.Property(e => e.IdProduct).HasColumnName("id_product");

                entity.Property(e => e.DiscountProduct).HasColumnName("discount_product");

                entity.Property(e => e.IdService).HasColumnName("id_service");

                entity.Property(e => e.NameProduct)
                    .HasMaxLength(200)
                    .IsUnicode(false)
                    .HasColumnName("name_product");

                entity.Property(e => e.PriceProduct)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("price_product");

                entity.Property(e => e.RegDeleted)
                    .HasColumnName("reg_deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.UrlProduct)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("url_product");

                entity.HasOne(d => d.IdServiceNavigation)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.IdService)
                    .HasConstraintName("fk_product_service");
            });

            modelBuilder.Entity<ServiceCommerce>(entity =>
            {
                entity.HasKey(e => e.IdService)
                    .HasName("pk_id_service");

                entity.ToTable("serviceCommerce");

                entity.Property(e => e.IdService).HasColumnName("id_service");

                entity.Property(e => e.DescriptionService)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("description_service");

                entity.Property(e => e.DiscountService)
                    .HasColumnName("discount_service")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.HomeService)
                    .HasColumnName("home_service")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.IdCategory).HasColumnName("id_category");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.ImageService)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("image_service");

                entity.Property(e => e.InternationalCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("international_code")
                    .IsFixedLength();

                entity.Property(e => e.Latitud).HasColumnName("latitud");

                entity.Property(e => e.Longitud).HasColumnName("longitud");

                entity.Property(e => e.NameService)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name_service");

                entity.Property(e => e.PhoneService)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("phone_service");

                entity.Property(e => e.RegDeleted)
                    .HasColumnName("reg_deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.VerifiedService)
                    .HasColumnName("verified_service")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.WhatsappService)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("whatsapp_service");

                entity.HasOne(d => d.IdCategoryNavigation)
                    .WithMany(p => p.ServiceCommerces)
                    .HasForeignKey(d => d.IdCategory)
                    .HasConstraintName("fk_service_category");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.ServiceCommerces)
                    .HasForeignKey(d => d.IdUser)
                    .HasConstraintName("fk_service_user");
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.HasKey(e => e.IdState)
                    .HasName("pk_id_state");

                entity.ToTable("state");

                entity.Property(e => e.IdState).HasColumnName("id_state");

                entity.Property(e => e.IdCountry).HasColumnName("id_country");

                entity.Property(e => e.NameState)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("name_state");

                entity.HasOne(d => d.IdCountryNavigation)
                    .WithMany(p => p.States)
                    .HasForeignKey(d => d.IdCountry)
                    .HasConstraintName("fk_country_state");
            });

            modelBuilder.Entity<Subscription>(entity =>
            {
                entity.HasKey(e => e.IdSubscription)
                    .HasName("pk_id_subscription");

                entity.ToTable("subscription");

                entity.Property(e => e.IdSubscription).HasColumnName("id_subscription");

                entity.Property(e => e.Description)
                    .HasMaxLength(300)
                    .IsUnicode(false)
                    .HasColumnName("description");

                entity.Property(e => e.NumberDay).HasColumnName("number_day");

                entity.Property(e => e.RegDeleted)
                    .HasColumnName("reg_deleted")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("pk_id_user");

                entity.ToTable("user");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.CreateService)
                    .HasColumnName("create_service")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.IdCity).HasColumnName("id_city");

                entity.Property(e => e.LastName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("last_name");

                entity.Property(e => e.NameUser)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name_user");

                entity.Property(e => e.Password)
                    .HasMaxLength(500)
                    .IsUnicode(false)
                    .HasColumnName("password");

                entity.Property(e => e.Picture)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("picture");

                entity.Property(e => e.RegDeleted)
                    .HasColumnName("reg_deleted")
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.IdCityNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.IdCity)
                    .HasConstraintName("fk_user_city");
            });

            modelBuilder.Entity<VwService>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_services");

                entity.Property(e => e.DescriptionService)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("description_service");

                entity.Property(e => e.DiscountService).HasColumnName("discount_service");

                entity.Property(e => e.IdCategory).HasColumnName("id_category");

                entity.Property(e => e.IdService).HasColumnName("id_service");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.ImageService)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("image_service");

                entity.Property(e => e.NameService)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name_service");

                entity.Property(e => e.Raiting).HasColumnName("raiting");
            });

            modelBuilder.Entity<VwServicesDetail>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_services_detail");

                entity.Property(e => e.DescriptionService)
                    .HasMaxLength(1500)
                    .IsUnicode(false)
                    .HasColumnName("description_service");

                entity.Property(e => e.DiscountService).HasColumnName("discount_service");

                entity.Property(e => e.HomeService).HasColumnName("home_service");

                entity.Property(e => e.IdCategory).HasColumnName("id_category");

                entity.Property(e => e.IdService).HasColumnName("id_service");

                entity.Property(e => e.IdUser).HasColumnName("id_user");

                entity.Property(e => e.ImageService)
                    .HasMaxLength(1000)
                    .IsUnicode(false)
                    .HasColumnName("image_service");

                entity.Property(e => e.InternationalCode)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .HasColumnName("international_code")
                    .IsFixedLength();

                entity.Property(e => e.Latitud).HasColumnName("latitud");

                entity.Property(e => e.Longitud).HasColumnName("longitud");

                entity.Property(e => e.NameService)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasColumnName("name_service");

                entity.Property(e => e.PhoneService)
                    .HasMaxLength(10)
                    .IsUnicode(false)
                    .HasColumnName("phone_service");

                entity.Property(e => e.Raiting)
                    .HasColumnType("decimal(10, 1)")
                    .HasColumnName("raiting");

                entity.Property(e => e.RegDeleted).HasColumnName("reg_deleted");

                entity.Property(e => e.VerifiedService).HasColumnName("verified_service");

                entity.Property(e => e.WhatsappService)
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasColumnName("whatsapp_service");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
