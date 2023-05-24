using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace masterdata.website.Migrations
{
    /// <inheritdoc />
    public partial class MasterData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PassWord = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WardId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    DistrictId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ProvinceId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Type = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    IsActived = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsAdmin = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cover = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeptId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Facebook = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Line = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListSiteId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxIdNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RepresentName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Banner",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageMobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FromTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BannerPlaceId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedUser = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Banner", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BannerPlace",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FromTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteId = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "0"),
                    LanguageId = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "vi-VN"),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedUser = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BannerPlace", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Category",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Policy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActived = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    BannerPlaceId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    SiteId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    LanguageId = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "vi-VN"),
                    FilterShortcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaKeyword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedUser = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Dept",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    IsActived = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    SiteId = table.Column<int>(type: "int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dept", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gallery",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Video = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImageMobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActived = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedUser = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gallery", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HTML",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActived = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    SiteId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    LanguageId = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "vi-VN")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HTML", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Label",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayText = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "0"),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BackgroundColor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActived = table.Column<bool>(type: "bit", nullable: false),
                    SiteId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    LanguageId = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "vi-VN")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Label", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Language",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LanguageId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    IsActived = table.Column<bool>(type: "bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Language", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Log",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SiteId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "vi-VN")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Log", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Manufacture",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Policy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    IsActived = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    BannerPlaceId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    SiteId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    LanguageId = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "vi-VN"),
                    MetaTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaKeyword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedUser = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacture", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WardId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    DistrictId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ProvinceId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CustomerNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    SellerNote = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    TotalWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    IsShow = table.Column<bool>(type: "bit", nullable: false, defaultValue: true),
                    SiteId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    LanguageId = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "vi-VN"),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedUser = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Page",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    IsActived = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "vi-VN")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Page", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PageRole",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    PageId = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedUser = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PageRole", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OwnCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TradeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageId = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "vi-VN"),
                    SiteId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    CategoryId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ManufactureId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    RedirectUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RedirectFromTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RedirectToTime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tags = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetaKeyword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActived = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    GrossWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    Width = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    Length = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    WarrantyInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Policy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specifications = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Thumb = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThumbMobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ListLabelId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsEndOfLife = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    IsInComing = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    RemainCount = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    SoldCount = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ViewsCount = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    IsShowPrice = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    SalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    WholeSalePrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    ImportPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedUser = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Promotion",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ValuePromotion = table.Column<decimal>(type: "decimal(18,2)", nullable: false, defaultValue: 0m),
                    TextPromotion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ProductIds = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryIds = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FromTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ToTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedUser = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SiteId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    LanguageId = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "vi-VN")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotion", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Site",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShortName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    IsActived = table.Column<bool>(type: "bit", nullable: false, defaultValue: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageId = table.Column<string>(type: "nvarchar(max)", nullable: false, defaultValue: "vi-VN"),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gmap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WorkTime = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Site", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderId = table.Column<int>(type: "int", nullable: false, defaultValue: 0),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    PromotionId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_OrderId",
                table: "OrderDetail",
                column: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Account");

            migrationBuilder.DropTable(
                name: "Banner");

            migrationBuilder.DropTable(
                name: "BannerPlace");

            migrationBuilder.DropTable(
                name: "Category");

            migrationBuilder.DropTable(
                name: "Dept");

            migrationBuilder.DropTable(
                name: "Gallery");

            migrationBuilder.DropTable(
                name: "HTML");

            migrationBuilder.DropTable(
                name: "Label");

            migrationBuilder.DropTable(
                name: "Language");

            migrationBuilder.DropTable(
                name: "Log");

            migrationBuilder.DropTable(
                name: "Manufacture");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "Page");

            migrationBuilder.DropTable(
                name: "PageRole");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "Promotion");

            migrationBuilder.DropTable(
                name: "Site");

            migrationBuilder.DropTable(
                name: "Order");
        }
    }
}
