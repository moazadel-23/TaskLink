using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using TaskLink.Models;

namespace TaskLink.Data;

public partial class ApplicationDbContext : DbContext
{
    public ApplicationDbContext()
    {
    }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Actor> Actors { get; set; }

    public virtual DbSet<Address> Addresses { get; set; }

    public virtual DbSet<Brand> Brands { get; set; }

    public virtual DbSet<Category> Categories { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Director> Directors { get; set; }

    public virtual DbSet<Emp2> Emp2s { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<Employee1> Employees1 { get; set; }

    public virtual DbSet<Genre> Genres { get; set; }

    public virtual DbSet<Log> Logs { get; set; }

    public virtual DbSet<Log1> Logs1 { get; set; }

    public virtual DbSet<Movie> Movies { get; set; }

    public virtual DbSet<Movie1> Movies1 { get; set; }

    public virtual DbSet<MovieCast> MovieCasts { get; set; }

    public virtual DbSet<MovieDirector> MovieDirectors { get; set; }

    public virtual DbSet<MovieGenre> MovieGenres { get; set; }

    public virtual DbSet<Order> Orders { get; set; }

    public virtual DbSet<OrderItem> OrderItems { get; set; }

    public virtual DbSet<Part> Parts { get; set; }

    public virtual DbSet<Product> Products { get; set; }

    public virtual DbSet<ProductAudit> ProductAudits { get; set; }

    public virtual DbSet<ProductionView> ProductionViews { get; set; }

    public virtual DbSet<Rating> Ratings { get; set; }

    public virtual DbSet<Rating1> Ratings1 { get; set; }

    public virtual DbSet<Reviewer> Reviewers { get; set; }

    public virtual DbSet<Reviewer1> Reviewers1 { get; set; }

    public virtual DbSet<Staff> Staffs { get; set; }

    public virtual DbSet<Stock> Stocks { get; set; }

    public virtual DbSet<Store> Stores { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Bikestories519;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Actor>(entity =>
        {
            entity.HasKey(e => e.ActId).HasName("PK__actor__EBC830956927236E");

            entity.Property(e => e.ActId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Address>(entity =>
        {
            entity.HasKey(e => e.AddressId).HasName("PK__addresse__CAA247C821943726");
        });

        modelBuilder.Entity<Brand>(entity =>
        {
            entity.HasKey(e => e.BrandId).HasName("PK__brands__5E5A8E2727B6E98C");
        });

        modelBuilder.Entity<Category>(entity =>
        {
            entity.HasKey(e => e.CategoryId).HasName("PK__categori__D54EE9B4F9A6E241");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerId).HasName("PK__customer__CD65CB855B09356D");
        });

        modelBuilder.Entity<Director>(entity =>
        {
            entity.HasKey(e => e.DirId).HasName("PK__director__D886CF4C6C5C93DD");

            entity.Property(e => e.DirId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Employee__3213E83F7A60EF82");

            entity.Property(e => e.Id).ValueGeneratedNever();
        });

        modelBuilder.Entity<Employee1>(entity =>
        {
            entity.HasKey(e => e.EmployeeId).HasName("PK__employee__C52E0BA8172AE369");
        });

        modelBuilder.Entity<Genre>(entity =>
        {
            entity.HasKey(e => e.GenId).HasName("PK__genres__7268D78B357279E8");

            entity.Property(e => e.GenId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Log>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__logs__9E2397E08CBA549B");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Log1>(entity =>
        {
            entity.HasKey(e => e.LogId).HasName("PK__logs__9E2397E064561604");

            entity.Property(e => e.CreatedAt).HasDefaultValueSql("(getdate())");
        });

        modelBuilder.Entity<Movie>(entity =>
        {
            entity.HasOne(d => d.Mov).WithMany().HasConstraintName("FK__movie__mov_id__619B8048");
        });

        modelBuilder.Entity<Movie1>(entity =>
        {
            entity.HasKey(e => e.MovId).HasName("PK__movie__D1BE75C7C0596B12");

            entity.Property(e => e.MovId).ValueGeneratedNever();
        });

        modelBuilder.Entity<MovieCast>(entity =>
        {
            entity.HasKey(e => e.MovId).HasName("PK__movie_ca__D1BE75C7AB548137");

            entity.Property(e => e.MovId).ValueGeneratedNever();
            entity.Property(e => e.Role).IsFixedLength();

            entity.HasOne(d => d.Act).WithMany(p => p.MovieCasts).HasConstraintName("FK__movie_cas__act_i__5FB337D6");
        });

        modelBuilder.Entity<MovieDirector>(entity =>
        {
            entity.HasOne(d => d.Dir).WithMany().HasConstraintName("FK__movie_dir__dir_i__6D0D32F4");

            entity.HasOne(d => d.Mov).WithMany().HasConstraintName("FK__movie_dir__mov_i__6E01572D");
        });

        modelBuilder.Entity<MovieGenre>(entity =>
        {
            entity.HasOne(d => d.Gen).WithMany().HasConstraintName("FK__movie_gen__gen_i__7C4F7684");

            entity.HasOne(d => d.Mov).WithMany().HasConstraintName("FK__movie_gen__mov_i__7B5B524B");
        });

        modelBuilder.Entity<Order>(entity =>
        {
            entity.HasKey(e => e.OrderId).HasName("PK__orders__465962297C4EDE0F");

            entity.ToTable("orders", "sales", tb => tb.HasTrigger("after_add"));

            entity.HasOne(d => d.Customer).WithMany(p => p.Orders)
                .OnDelete(DeleteBehavior.Cascade)
                .HasConstraintName("FK__orders__customer__47DBAE45");

            entity.HasOne(d => d.Staff).WithMany(p => p.Orders)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__orders__staff_id__49C3F6B7");

            entity.HasOne(d => d.Store).WithMany(p => p.Orders).HasConstraintName("FK__orders__store_id__48CFD27E");
        });

        modelBuilder.Entity<OrderItem>(entity =>
        {
            entity.HasKey(e => new { e.OrderId, e.ItemId }).HasName("PK__order_it__837942D4DED50FDA");

            entity.HasOne(d => d.Order).WithMany(p => p.OrderItems).HasConstraintName("FK__order_ite__order__4D94879B");

            entity.HasOne(d => d.Product).WithMany(p => p.OrderItems).HasConstraintName("FK__order_ite__produ__4E88ABD4");
        });

        modelBuilder.Entity<Part>(entity =>
        {
            entity.HasKey(e => e.PartId).HasName("PK__parts__A0E3FAB884B73633");

            entity.Property(e => e.PartId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Product>(entity =>
        {
            entity.HasKey(e => e.ProductId).HasName("PK__products__47027DF5BA2107F6");

            entity.HasOne(d => d.Brand).WithMany(p => p.Products).HasConstraintName("FK__products__brand___3C69FB99");

            entity.HasOne(d => d.Category).WithMany(p => p.Products).HasConstraintName("FK__products__catego__3B75D760");
        });

        modelBuilder.Entity<ProductAudit>(entity =>
        {
            entity.HasKey(e => e.ChangeId).HasName("PK__product___F4EFE596D3ABE9B8");

            entity.Property(e => e.Operation).IsFixedLength();
        });

        modelBuilder.Entity<ProductionView>(entity =>
        {
            entity.ToView("production_view");
        });

        modelBuilder.Entity<Rating>(entity =>
        {
            entity.HasOne(d => d.Mov).WithMany().HasConstraintName("FK__rating__mov_id__73BA3083");

            entity.HasOne(d => d.Rev).WithMany().HasConstraintName("FK__rating__rev_id__74AE54BC");
        });

        modelBuilder.Entity<Rating1>(entity =>
        {
            entity.HasOne(d => d.Mov).WithMany().HasConstraintName("FK__rating__mov_id__76969D2E");

            entity.HasOne(d => d.Rev).WithMany().HasConstraintName("FK__rating__rev_id__778AC167");
        });

        modelBuilder.Entity<Reviewer>(entity =>
        {
            entity.HasKey(e => e.RecId).HasName("PK__reviewer__97D3CABD791BF1AB");

            entity.Property(e => e.RecId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Reviewer1>(entity =>
        {
            entity.HasKey(e => e.RevId).HasName("PK__reviewer__397465D64170946B");

            entity.Property(e => e.RevId).ValueGeneratedNever();
        });

        modelBuilder.Entity<Staff>(entity =>
        {
            entity.HasKey(e => e.StaffId).HasName("PK__staffs__1963DD9C8D3F09D4");

            entity.HasOne(d => d.Manager).WithMany(p => p.InverseManager).HasConstraintName("FK__staffs__manager___44FF419A");

            entity.HasOne(d => d.Store).WithMany(p => p.Staff).HasConstraintName("FK__staffs__store_id__440B1D61");
        });

        modelBuilder.Entity<Stock>(entity =>
        {
            entity.HasKey(e => new { e.StoreId, e.ProductId }).HasName("PK__stocks__E68284D397B45893");

            entity.HasOne(d => d.Product).WithMany(p => p.Stocks).HasConstraintName("FK__stocks__product___52593CB8");

            entity.HasOne(d => d.Store).WithMany(p => p.Stocks).HasConstraintName("FK__stocks__store_id__5165187F");
        });

        modelBuilder.Entity<Store>(entity =>
        {
            entity.HasKey(e => e.StoreId).HasName("PK__stores__A2F2A30CD98184CD");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
