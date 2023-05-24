using System.Security.Cryptography.X509Certificates;
using System;

namespace masterdata.website.Models
{
    public class Manufacture
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string Policy { get; set; }
        public string Url { get; set; }
        public int DisplayOrder { get; set; }
        public string Logo { get; set; }
        /// <summary>
        /// Phân loại
        /// 0: Hãng sản xuất
        /// 1: Thương hiệu
        /// 2: Nhà cung cấp
        /// </summary>
        public int Type { get; set; }
        public bool IsActived { get; set; }
        public bool IsDeleted { get; set; }
        public int BannerPlaceId { get; set; }
        public int SiteId { get; set; }
        public string LanguageId { get; set; }

        public string MetaTitle { get; set; }
        public string MetaDescription { get; set; }
        public string MetaKeyword { get; set; }

        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public DateTime DeletedDate { get; set; }
        public string DeletedUser { get; set; }
    }
}
