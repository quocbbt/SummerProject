using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using masterdata.website.Models;

namespace masterdata.website.Configuration
{
    #region User
    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.ToTable("Account");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UserName);
            builder.Property(x => x.PassWord);
            builder.Property(x => x.Email);
            builder.Property(x => x.Phone);
            builder.Property(x => x.Address);
            builder.Property(x => x.WardId).HasDefaultValue(0);
            builder.Property(x => x.DistrictId).HasDefaultValue(0);
            builder.Property(x => x.ProvinceId).HasDefaultValue(0);
            builder.Property(x => x.Type).HasDefaultValue(0);
            builder.Property(x => x.IsActived).HasDefaultValue(true);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.IsAdmin).HasDefaultValue(false);
            builder.Property(x => x.FullName);
            builder.Property(x => x.Avatar);
            builder.Property(x => x.Cover);
            builder.Property(x => x.Dob);
            builder.Property(x => x.DeptId).HasDefaultValue(0);
            builder.Property(x => x.Facebook);
            builder.Property(x => x.Line);
            builder.Property(x => x.CreatedDate);
            builder.Property(x => x.CreatedUser);
            builder.Property(x => x.UpdatedDate).HasDefaultValue(null);
            builder.Property(x => x.UpdatedUser);
            builder.Property(x => x.DeletedDate).HasDefaultValue(null);
            builder.Property(x => x.DeletedUser);
            builder.Property(x => x.Token);
            builder.Property(x => x.ListSiteId);
            builder.Property(x => x.TaxIdNumber);
            builder.Property(x => x.RepresentName);
        }
    }
    public class DeptConfiguration : IEntityTypeConfiguration<Dept>
    {
        public void Configure(EntityTypeBuilder<Dept> builder)
        {
            builder.ToTable("Dept");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.ShortName);
            builder.Property(x => x.Icon);
            builder.Property(x => x.Description);
            builder.Property(x => x.DisplayOrder).HasDefaultValue(0);
            builder.Property(x => x.IsActived).HasDefaultValue(false);
            builder.Property(x => x.SiteId).HasDefaultValue(0);
        }
    }
    public class PageRoleConfiguration : IEntityTypeConfiguration<PageRole>
    {
        public void Configure(EntityTypeBuilder<PageRole> builder)
        {
            builder.ToTable("PageRole");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.UserId);
            builder.Property(x => x.PageId);
            builder.Property(x => x.Type).HasDefaultValue(0);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedDate);
            builder.Property(x => x.CreatedUser);
            builder.Property(x => x.DeletedDate).HasDefaultValue(null);
            builder.Property(x => x.DeletedUser);
        }
    }
    #endregion

    #region Site
    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> builder)
        {
            builder.ToTable("Language");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.LanguageId);
            builder.Property(x => x.Name);
            builder.Property(x => x.Icon);
            builder.Property(x => x.Description);
            builder.Property(x => x.DisplayOrder).HasDefaultValue(0);
            builder.Property(x => x.IsActived).HasDefaultValue(false);
        }
    }

    public class SiteConfiguration : IEntityTypeConfiguration<Site>
    {
        public void Configure(EntityTypeBuilder<Site> builder)
        {
            builder.ToTable("Site");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.ShortName);
            builder.Property(x => x.Icon);
            builder.Property(x => x.Description);
            builder.Property(x => x.DisplayOrder);
            builder.Property(x => x.IsActived).HasDefaultValue(false);
            builder.Property(x => x.Url);
            builder.Property(x => x.LanguageId).HasDefaultValue("vi-VN");
            builder.Property(x => x.Logo);
            builder.Property(x => x.Address);
            builder.Property(x => x.Phone);
            builder.Property(x => x.Email);
            builder.Property(x => x.Gmap);
            builder.Property(x => x.WorkTime);
        }
    }

    public class PageConfiguration : IEntityTypeConfiguration<Page>
    {
        public void Configure(EntityTypeBuilder<Page> builder)
        {
            builder.ToTable("Page");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.ShortName);
            builder.Property(x => x.Icon);
            builder.Property(x => x.Description);
            builder.Property(x => x.DisplayOrder);
            builder.Property(x => x.IsActived).HasDefaultValue(false);
            builder.Property(x => x.Url);
            builder.Property(x => x.LanguageId).HasDefaultValue("vi-VN");
        }
    }

    public class HTMLConfiguration : IEntityTypeConfiguration<HTML>
    {
        public void Configure(EntityTypeBuilder<HTML> builder)
        {
            builder.ToTable("HTML");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.Description);
            builder.Property(x => x.IsActived).HasDefaultValue(false);
            builder.Property(x => x.SiteId).HasDefaultValue(0);
            builder.Property(x => x.LanguageId).HasDefaultValue("vi-VN");
        }
    }
    #endregion

    #region Category
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.ToTable("Category");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ParentId).HasDefaultValue(0);
            builder.Property(x => x.Name);
            builder.Property(x => x.ShortName);
            builder.Property(x => x.Description);
            builder.Property(x => x.ShortDescription);
            builder.Property(x => x.Url);
            builder.Property(x => x.DisplayOrder).HasDefaultValue(0);
            builder.Property(x => x.Logo);
            builder.Property(x => x.IsActived).HasDefaultValue(false);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.BannerPlaceId).HasDefaultValue(0);
            builder.Property(x => x.SiteId).HasDefaultValue(0);
            builder.Property(x => x.LanguageId).HasDefaultValue("vi-VN");
            builder.Property(x => x.FilterShortcode);
            builder.Property(x => x.MetaTitle);
            builder.Property(x => x.MetaDescription);
            builder.Property(x => x.MetaKeyword);
            builder.Property(x => x.CreatedDate);
            builder.Property(x => x.CreatedUser);
            builder.Property(x => x.UpdatedDate).HasDefaultValue(null);
            builder.Property(x => x.UpdatedUser);
            builder.Property(x => x.DeletedDate).HasDefaultValue(null);
            builder.Property(x => x.DeletedUser);
        }
    }
    #endregion

    #region Product
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Product");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.ProductCode);
            builder.Property(x => x.ManufactureProductCode);
            builder.Property(x => x.Name);
            builder.Property(x => x.ShortName);
            builder.Property(x => x.TradeName);
            builder.Property(x => x.Url);
            builder.Property(x => x.SiteId).HasDefaultValue(0);
            builder.Property(x => x.CategoryId).HasDefaultValue(0);
            builder.Property(x => x.ProviderId).HasDefaultValue(0);
            builder.Property(x => x.ManufactureId).HasDefaultValue(0);
            builder.Property(x => x.LanguageId).HasDefaultValue("vi-VN");

            builder.Property(x => x.RedirectUrl);
            builder.Property(x => x.RedirectFromTime);
            builder.Property(x => x.RedirectToTime);

            builder.Property(x => x.Tags);
            builder.Property(x => x.MetaTitle);
            builder.Property(x => x.MetaDescription);
            builder.Property(x => x.MetaKeyword);

            builder.Property(x => x.IsActived).HasDefaultValue(false);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.DisplayOrder).HasDefaultValue(0);

            builder.Property(x => x.GrossWeight).HasDefaultValue(0);
            builder.Property(x => x.Width).HasDefaultValue(0);
            builder.Property(x => x.Length).HasDefaultValue(0);
            builder.Property(x => x.Height).HasDefaultValue(0);
            builder.Property(x => x.Volume).HasDefaultValue(0);

            builder.Property(x => x.WarrantyInfo);
            builder.Property(x => x.Policy);
            builder.Property(x => x.Description);
            builder.Property(x => x.Specifications);
            builder.Property(x => x.Thumb);
            builder.Property(x => x.ThumbMobile);
            builder.Property(x => x.ListLabelId);
            builder.Property(x => x.IsEndOfLife).HasDefaultValue(false);
            builder.Property(x => x.IsInComing).HasDefaultValue(false);

            builder.Property(x => x.RemainCount).HasDefaultValue(0);
            builder.Property(x => x.SoldCount).HasDefaultValue(0);
            builder.Property(x => x.ViewsCount).HasDefaultValue(0);
            builder.Property(x => x.IsShowPrice).HasDefaultValue(false);
            builder.Property(x => x.SalePrice).HasDefaultValue(0);
            builder.Property(x => x.WholeSalePrice).HasDefaultValue(0);
            builder.Property(x => x.ImportPrice).HasDefaultValue(0);
            builder.Property(x => x.ImportVAT).HasDefaultValue(0);
            builder.Property(x => x.ExportVAT).HasDefaultValue(0);

            builder.Property(x => x.CreatedDate);
            builder.Property(x => x.CreatedUser);
            builder.Property(x => x.UpdatedDate).HasDefaultValue(null);
            builder.Property(x => x.UpdatedUser);
            builder.Property(x => x.DeletedDate).HasDefaultValue(null);
            builder.Property(x => x.DeletedUser);
        }
    }
    #endregion

    #region Manufacture
    public class ManufactureConfiguration : IEntityTypeConfiguration<Manufacture>
    {
        public void Configure(EntityTypeBuilder<Manufacture> builder)
        {
            builder.ToTable("Manufacture");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.ShortName);
            builder.Property(x => x.Description);
            builder.Property(x => x.ShortDescription);
            builder.Property(x => x.Policy);
            builder.Property(x => x.Url);
            builder.Property(x => x.DisplayOrder).HasDefaultValue(0);
            builder.Property(x => x.Logo);
            builder.Property(x => x.Type).HasDefaultValue(0);
            builder.Property(x => x.IsActived).HasDefaultValue(false);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.BannerPlaceId).HasDefaultValue(0);
            builder.Property(x => x.SiteId).HasDefaultValue(0);
            builder.Property(x => x.LanguageId).HasDefaultValue("vi-VN");

            builder.Property(x => x.MetaTitle);
            builder.Property(x => x.MetaDescription);
            builder.Property(x => x.MetaKeyword);

            builder.Property(x => x.CreatedDate);
            builder.Property(x => x.CreatedUser);
            builder.Property(x => x.UpdatedDate).HasDefaultValue(null);
            builder.Property(x => x.UpdatedUser);
            builder.Property(x => x.DeletedDate).HasDefaultValue(null);
            builder.Property(x => x.DeletedUser);
        }
    }
    #endregion

    #region Banner
    public class BannerConfiguration : IEntityTypeConfiguration<Banner>
    {
        public void Configure(EntityTypeBuilder<Banner> builder)
        {
            builder.ToTable("Banner");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.Description);
            builder.Property(x => x.Url);
            builder.Property(x => x.DisplayOrder).HasDefaultValue(0);
            builder.Property(x => x.Image);
            builder.Property(x => x.ImageMobile);
            builder.Property(x => x.FromTime);
            builder.Property(x => x.ToTime);
            builder.Property(x => x.BannerPlaceId).HasDefaultValue(0);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedDate);
            builder.Property(x => x.CreatedUser);
            builder.Property(x => x.UpdatedDate).HasDefaultValue(null);
            builder.Property(x => x.UpdatedUser);
            builder.Property(x => x.DeletedDate).HasDefaultValue(null);
            builder.Property(x => x.DeletedUser);
        }
    }

    public class BannerPlaceConfiguration : IEntityTypeConfiguration<BannerPlace>
    {
        public void Configure(EntityTypeBuilder<BannerPlace> builder)
        {
            builder.ToTable("BannerPlace");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.Description);
            builder.Property(x => x.FromTime);
            builder.Property(x => x.ToTime);
            builder.Property(x => x.SiteId).HasDefaultValue(0);
            builder.Property(x => x.LanguageId).HasDefaultValue("vi-VN");
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedDate);
            builder.Property(x => x.CreatedUser);
            builder.Property(x => x.UpdatedDate).HasDefaultValue(null);
            builder.Property(x => x.UpdatedUser);
            builder.Property(x => x.DeletedDate).HasDefaultValue(null);
            builder.Property(x => x.DeletedUser);
        }
    }
    #endregion

    #region Log
    public class LogConfiguration : IEntityTypeConfiguration<Log>
    {
        public void Configure(EntityTypeBuilder<Log> builder)
        {
            builder.ToTable("Log");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Type);
            builder.Property(x => x.Detail);
            builder.Property(x => x.CreatedDate);
            builder.Property(x => x.SiteId);
            builder.Property(x => x.LanguageId).HasDefaultValue("vi-VN");
        }
    }
    #endregion

    #region Gallery
    public class GalleryConfiguration : IEntityTypeConfiguration<Gallery>
    {
        public void Configure(EntityTypeBuilder<Gallery> builder)
        {
            builder.ToTable("Gallery");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.Description);
            builder.Property(x => x.DisplayText);
            builder.Property(x => x.DisplayOrder).HasDefaultValue(0);
            builder.Property(x => x.Video);
            builder.Property(x => x.Image);
            builder.Property(x => x.ImageMobile);
            builder.Property(x => x.IsActived);
            builder.Property(x => x.IsDeleted);
            builder.Property(x => x.CreatedDate);
            builder.Property(x => x.CreatedUser);
            builder.Property(x => x.UpdatedDate).HasDefaultValue(null);
            builder.Property(x => x.UpdatedUser);
            builder.Property(x => x.DeletedDate).HasDefaultValue(null);
            builder.Property(x => x.DeletedUser);
        }
    }
    public class LabelConfiguration : IEntityTypeConfiguration<Label>
    {
        public void Configure(EntityTypeBuilder<Label> builder)
        {
            builder.ToTable("Label");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.DisplayText);
            builder.Property(x => x.DisplayOrder).HasDefaultValue(0);
            builder.Property(x => x.Icon);
            builder.Property(x => x.BackgroundColor);
            builder.Property(x => x.SiteId).HasDefaultValue(0);
            builder.Property(x => x.LanguageId).HasDefaultValue("vi-VN");
        }
    }
    #endregion

    #region Promotion
    public class PromotionConfiguration : IEntityTypeConfiguration<Promotion>
    {
        public void Configure(EntityTypeBuilder<Promotion> builder)
        {
            builder.ToTable("Promotion");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name);
            builder.Property(x => x.Description);
            builder.Property(x => x.ValuePromotion).HasDefaultValue(0);
            builder.Property(x => x.TextPromotion);
            builder.Property(x => x.DisplayOrder).HasDefaultValue(0);
            builder.Property(x => x.ProductIds);
            builder.Property(x => x.CategoryIds);
            builder.Property(x => x.FromTime).HasDefaultValue(null);
            builder.Property(x => x.ToTime).HasDefaultValue(null);
            builder.Property(x => x.Quantity).HasDefaultValue(0);
            builder.Property(x => x.IsDeleted).HasDefaultValue(false);
            builder.Property(x => x.CreatedDate);
            builder.Property(x => x.CreatedUser);
            builder.Property(x => x.UpdatedDate).HasDefaultValue(null);
            builder.Property(x => x.UpdatedUser);
            builder.Property(x => x.DeletedDate).HasDefaultValue(null);
            builder.Property(x => x.DeletedUser);
            builder.Property(x => x.SiteId).HasDefaultValue(0);
            builder.Property(x => x.LanguageId).HasDefaultValue("vi-VN");
        }
    }
    #endregion

    #region Promotion
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.ToTable("Order");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.CustomerName);
            builder.Property(x => x.Phone);
            builder.Property(x => x.Email);
            builder.Property(x => x.Address);
            builder.Property(x => x.WardId).HasDefaultValue(0);
            builder.Property(x => x.DistrictId).HasDefaultValue(0);
            builder.Property(x => x.ProvinceId).HasDefaultValue(0);
            builder.Property(x => x.CustomerNote);
            builder.Property(x => x.Status).HasDefaultValue(0);
            builder.Property(x => x.SellerNote);
            builder.Property(x => x.Total).HasDefaultValue(0);
            builder.Property(x => x.TotalWeight).HasDefaultValue(0);
            builder.Property(x => x.IsShow).HasDefaultValue(true);

            builder.Property(x => x.SiteId).HasDefaultValue(0);
            builder.Property(x => x.LanguageId).HasDefaultValue("vi-VN");
            builder.Property(x => x.CreatedDate);
            builder.Property(x => x.CreatedUser);
            builder.Property(x => x.UpdatedDate).HasDefaultValue(null);
            builder.Property(x => x.UpdatedUser);
            builder.Property(x => x.DeletedDate).HasDefaultValue(null);
            builder.Property(x => x.DeletedUser);
        }
    }
    public class OrderDetailConfiguration : IEntityTypeConfiguration<OrderDetail>
    {
        public void Configure(EntityTypeBuilder<OrderDetail> builder)
        {
            builder.ToTable("OrderDetail");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.OrderId).HasDefaultValue(0);
            builder.Property(x => x.ProductId);
            builder.Property(x => x.PromotionId);
            builder.Property(x => x.Quantity);
        }
    }
    #endregion
}
