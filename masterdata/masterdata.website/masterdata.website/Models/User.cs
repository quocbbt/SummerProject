namespace masterdata.website.Models
{
    public class Account
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string PassWord { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public int WardId { get; set; }
        public int DistrictId { get; set; }
        public int ProvinceId { get; set; }
        /// <summary>
        /// Loại thông tin user
        /// 0: Hệ thống
        /// 1: Đại lý
        /// 2: Khách hàng
        /// </summary>
        public int Type { get; set; }
        public bool IsActived { get; set; }
        public bool IsDeleted { get; set; }
        public bool IsAdmin { get; set; }
        public string FullName { get; set; }
        public string Avatar { get; set; }
        public string Cover { get; set; }
        public DateTime Dob { get; set; }
        public int DeptId { get; set; }
        public string Facebook { get; set; }
        public string Line { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public DateTime DeletedDate { get; set; }
        public string DeletedUser { get; set; }
        public string Token { get; set; }
        public string ListSiteId { get; set; }
        public string TaxIdNumber { get; set; }
        public string RepresentName { get; set; }

    }

    public class Dept
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActived { get; set; }
        public int SiteId { get; set; }
    }

    public class PageRole
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int PageId { get; set; }
        /// <summary>
        /// Loại Role
        /// 0: UserRole
        /// 1: DeptRole
        /// </summary>
        public int Type { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime DeletedDate { get; set; }
        public string DeletedUser { get; set; }

    }
}
