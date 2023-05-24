namespace masterdata.website.Models
{
    public class Gallery
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }      
        public string DisplayText { get; set; }      
        public int DisplayOrder { get; set; }
        public string Video { get; set; }
        public string Image { get; set; }
        public string ImageMobile { get; set; }
        public bool IsActived { get; set; }
        public bool IsDeleted { get; set; }
        public int ProductId { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime UpdatedDate { get; set; }
        public string UpdatedUser { get; set; }
        public DateTime DeletedDate { get; set; }
        public string DeletedUser { get; set; }
    }
}
