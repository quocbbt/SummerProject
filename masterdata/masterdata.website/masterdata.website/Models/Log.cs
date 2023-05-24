namespace masterdata.website.Models
{
    public class Log
    {
        public int Id { get; set; }
        /// <summary>
        /// LogType
        /// 0: Site
        /// 1: User
        /// 2: Category
        /// 3: Product
        /// 4: News Category
        /// 5: News
        /// 6: Banner
        /// 7: Gallery
        /// </summary>
        public int Type { get; set; }
        public string Detail { get; set; }
        public DateTime CreatedDate { get; set; }
        public int SiteId { get; set; }
        public string LanguageId { get; set; }
    }
}
