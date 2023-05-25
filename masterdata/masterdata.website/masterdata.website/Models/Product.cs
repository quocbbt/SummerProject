namespace masterdata.website.Models
{
    public class Product
    {
        public int Id { get; set; }
        /// <summary>
        /// Mã sản phẩm
        /// </summary>
        public string ProductCode { get; set; }
        /// <summary>
        /// Mã sản phẩm của hãng
        /// </summary>
        public string ManufactureProductCode { get; set; }
        /// <summary>
        /// Mã sản phẩm quy định lại
        /// </summary>
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string TradeName { get; set; }
        public string Url { get; set; }
        public string LanguageId { get; set; }
        public int SiteId { get; set; }
        public int CategoryId { get; set; }
        public int ProviderId { get; set; }
        public int ManufactureId { get; set; }

        public string RedirectUrl { get; set; }
        public string RedirectFromTime { get; set; }
        public string RedirectToTime { get; set; }

        public string Tags { get; set; }
        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyword { get; set; }

        public bool IsActived { get; set; }
        public bool IsDeleted { get; set; }
        public int DisplayOrder { get; set; }

        /// <summary>
        /// Kích thước, khối lượng để tính phí vận chuyển
        /// GrossWeight: Tổng khối lượng (kg)
        /// Width, Length, Height: Kích thước dài, rộng, cao (m)
        /// Volume: Thể tích (m3)
        /// </summary>

        public decimal GrossWeight { get; set; }
        public decimal Width { get; set; }
        public decimal Length { get; set; }
        public decimal Height { get; set; }
        public decimal Volume { get; set; }
        /// <summary>
        /// Đơn vị tính
        /// </summary>
        public int Unit { get; set; }
        public string PackingInfo { get; set; }
        public string LaunchingFrom { get; set; }
        public string WarrantyInfo { get; set; }
        public string Policy { get; set; }
        public string Description { get; set; }
        public string Specifications { get; set; }

        public string Thumb { get; set; }
        public string ThumbMobile { get; set; }
        /// <summary>
        /// Danh sách ID label áp dụng hiển thị
        /// </summary>
        public string ListLabelId { get; set; }

        public bool IsEndOfLife { get; set; }
        public bool IsInComing { get; set; }
        public int RemainCount { get; set; }
        public int SoldCount { get; set; }

        public int ViewsCount { get; set; }

        /// <summary>
        /// Khu vực giá
        /// </summary>
        public bool IsShowPrice { get; set; }
        public decimal SalePrice { get; set; }
        public decimal WholeSalePrice { get; set; }
        public decimal ImportPrice { get; set; }
        public decimal ImportVAT { get; set; }
        public decimal ExportVAT { get; set; }

        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public DateTime DeletedDate { get; set; }
        public string DeletedUser { get; set; }

    }
}
