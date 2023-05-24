namespace masterdata.website.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int WardId { get; set; }
        public int DistrictId { get; set; }
        public int ProvinceId { get; set; }
        public string CustomerNote { get; set; }
        /// <summary>
        /// Trạng thái đơn hàng
        /// 0: Nháp
        /// 1: Đã tạo
        /// 2: Đang xử lý
        /// 3: Đang giao hàng
        /// 4: Hoàn tất
        /// 5: Đã hủy
        /// </summary>
        public int Status { get; set; }
        public string SellerNote { get; set; }
        /// <summary>
        /// Tổng tiền
        /// </summary>
        public decimal Total { get; set; }
        /// <summary>
        /// Tổng khối lượng đơn hàng
        /// </summary>
        public decimal TotalWeight { get; set; }
        public bool IsShow { get; set; }
        public int SiteId { get; set; }
        public string LanguageId { get; set; }

        public List<OrderDetail> ListProductOrder { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public DateTime DeletedDate { get; set; }
        public string DeletedUser { get; set; }
    }

    public class OrderDetail
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int PromotionId { get; set; }
        public int Quantity { get; set; }
    }
}
