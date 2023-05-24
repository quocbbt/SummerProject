namespace masterdata.website.Models
{
    public class Promotion
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        /// <summary>
        /// Giá trị khuyến mãi
        /// Nếu giá trị KM nhỏ hơn 100 thì áp dụng KM theo %, ngược lại là khuyến mãi giảm tiền
        /// </summary>
        public decimal ValuePromotion { get; set; }
        /// <summary>
        /// Giá trị khuyến mãi text
        /// Nếu có cả Giá trị KM và KM Text thì ưu tiên Giá trị KM
        /// </summary>
        public string TextPromotion { get; set; }
        public int DisplayOrder { get; set; }
        /// <summary>
        /// ID sản phẩm áp dụng
        /// Nếu có cả 2 khai bái, ưu tiên áp dụng ID ngành hàng
        /// </summary>
        public string ProductIds { get; set; }
        /// <summary>
        /// ID ngành hàng áp dụng
        /// Nếu có cả 2 khai bái, ưu tiên áp dụng ID ngành hàng
        /// </summary>
        public string CategoryIds { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        /// <summary>
        /// Khai báo đếm suất khuyến mãi
        /// Lưu ý: Chỉ áp dụng khi khai báo 1 ID sản phẩm
        /// </summary>
        public int Quantity { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public DateTime DeletedDate { get; set; }
        public string DeletedUser { get; set; }
        public int SiteId { get; set; }
        public string LanguageId { get; set; }
    }

    public class Label
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DisplayText { get; set; }
        public string DisplayOrder { get; set; }
        public string Icon { get; set; }
        public string BackgroundColor { get; set; }
        public bool IsActived { get; set; }
        public int SiteId { get; set; }
        public string LanguageId { get; set; }
    }
}
