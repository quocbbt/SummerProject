using masterdata.website.Models;
using masterdata.website.Services.Categories;
using masterdata.website.Data;

namespace masterdata.website.Services.Categories
{
    public class CategoriesService : ICategoriesService
    {
        private readonly MasterDataDbContext _newCoreDbContext;

        public CategoriesService(MasterDataDbContext newCoreDbContext)
        {
            _newCoreDbContext = newCoreDbContext;
        }

        public List<Category> GetListCategoryBySite(int siteId)
        {
            List<Category>? listCategories = _newCoreDbContext.Categories.Where(x => x.SiteId == siteId)?.ToList();
            return listCategories;
        }

        public List<Category> SearchCategory(string? keyWord, int siteId)
        {
            List<Category>? listCategories = _newCoreDbContext.Categories.Where(x =>
            (string.IsNullOrEmpty(keyWord) || x.Name.Contains(keyWord) || x.Id.ToString().Contains(keyWord)) &&
            ((siteId <= 0) || x.SiteId == siteId))?.ToList();
            return listCategories;
        }

        public Category GetCategory(int id)
        {
            var category = _newCoreDbContext.Categories.FirstOrDefault(x => x.Id == id);
            return category;
        }

        public int InsertCategory(Category category)
        {
            _newCoreDbContext.Categories.Add(category);
            _newCoreDbContext.SaveChanges();
            return category.Id;
        }

        public bool UpdateCategory(Category category)
        {
            bool pageExist = _newCoreDbContext.Categories.Any(x => x.Id == category.Id);
            if (pageExist)
            {
                _newCoreDbContext.Categories.Update(category);
                _newCoreDbContext.SaveChanges();
                return true;
            }
            return false;
        }

        public bool DeleteCategory(int id)
        {
            Category category = _newCoreDbContext.Categories.FirstOrDefault(x => x.Id == id);
            if (category != null)
            {
                _newCoreDbContext.Categories.Remove(category);
                _newCoreDbContext.SaveChanges();
                return true;
            }
            return false;
        }
    }
}