namespace masterdata.website.Models
{
    public class Banner
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public int DisplayOrder { get; set; }
        public string Image { get; set; }
        public string ImageMobile { get; set; }
        public DateTime FromTime { get; set; }
        public DateTime ToTime { get; set; }
        public int BannerPlaceId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public DateTime DeletedDate { get; set; }
        public string DeletedUser { get; set; }
    }

    public class BannerPlace
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string FromTime { get; set; }
        public string ToTime { get; set; }
        public string SiteId { get; set; }
        public string LanguageId { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public DateTime DeletedDate { get; set; }
        public string DeletedUser { get; set; }
    }
}
