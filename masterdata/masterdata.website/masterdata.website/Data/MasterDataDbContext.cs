using Microsoft.EntityFrameworkCore;
using masterdata.website.Configuration;
using masterdata.website.Models;
using masterdata.website.Seeders;

namespace NewCoreAPI.Data
{
    public class MasterDataDbContext : DbContext
    {
        public MasterDataDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BannerConfiguration());
            modelBuilder.ApplyConfiguration(new BannerPlaceConfiguration());
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new GalleryConfiguration());
            modelBuilder.ApplyConfiguration(new LogConfiguration());
            modelBuilder.ApplyConfiguration(new ManufactureConfiguration());
            modelBuilder.ApplyConfiguration(new OrderConfiguration());
            modelBuilder.ApplyConfiguration(new OrderDetailConfiguration());
            modelBuilder.ApplyConfiguration(new ProductConfiguration());
            modelBuilder.ApplyConfiguration(new PromotionConfiguration());
            modelBuilder.ApplyConfiguration(new LabelConfiguration());
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new SiteConfiguration());
            modelBuilder.ApplyConfiguration(new PageConfiguration());
            modelBuilder.ApplyConfiguration(new HTMLConfiguration());
            modelBuilder.ApplyConfiguration(new AccountConfiguration());
            modelBuilder.ApplyConfiguration(new DeptConfiguration());
            modelBuilder.ApplyConfiguration(new PageRoleConfiguration());
            //modelBuilder.Seed();
        }

        public DbSet<Banner> Banners { get; set; }
        public DbSet<BannerPlace> BannerPlaces { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Gallery> Galleries { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Manufacture> Manufactures { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Promotion> Promotions { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<Language> Languages { get; set; }
        public DbSet<Site> Sites { get; set; }
        public DbSet<Page> Pages { get; set; }
        public DbSet<HTML> HTMLs { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Dept> Depts { get; set; }
        public DbSet<PageRole> PageRoles { get; set; }
    }
}
