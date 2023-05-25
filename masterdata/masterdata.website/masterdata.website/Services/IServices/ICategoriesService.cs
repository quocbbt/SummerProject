using masterdata.website.Models;

namespace masterdata.website.Services.Categories
{
    public interface ICategoriesService
    {
        Category GetCategory(int id);
        List<Category> GetListCategoryBySite(int siteId);
        List<Category> SearchCategory(string keyWord, int siteId);
        int InsertCategory(Category category);
        bool UpdateCategory(Category category);
        bool DeleteCategory(int id);
    }
}