namespace masterdata.website.Models
{
    public class Language
    {
        public int Id { get; set; }
        public string LanguageId { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActived { get; set; }
    }

    public class Site
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActived { get; set; }
        public string Url { get; set; }
        public string LanguageId { get; set; }

        /// <summary>
        /// Thông tin website
        /// 
        /// </summary>
        /// 

        public string Logo { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Gmap { get; set; }
        public string WorkTime { get; set; }
    }

    public class Page
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public int DisplayOrder { get; set; }
        public bool IsActived { get; set; }
        public string Url { get; set; }
        public int SiteId { get; set; }
        public string LanguageId { get; set; }
    }

    public class HTML
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Content { get; set; }
        public bool IsActived { get; set; }
        public int SiteId { get; set; }
        public string LanguageId { get; set; }
    }
}
