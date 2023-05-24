namespace masterdata.website.Models
{
    public class Category
    {
        public int Id { get; set; }
        public int ParentId { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public string ShortDescription { get; set; }
        public string Policy { get; set; }
        public string Url { get; set; }
        public int DisplayOrder { get; set; }
        public string Logo { get; set; }
        public bool IsActived { get; set; }
        public bool IsDeleted { get; set; }
        public int BannerPlaceId { get; set; }
        public int SiteId { get; set; }
        public string LanguageId { get; set; }

        /// <summary>
        /// Filter
        /// 
        /// </summary>
        public string FilterShortcode { get; set; }

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
