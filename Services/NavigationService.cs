using GameQuest.Data;
using GameQuest.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class NavigationService
{
    private Context _context;

    public static List<Content> menuItems = new List<Content>();

    public static List<CategoryPageModel> categoryItems = new List<CategoryPageModel>();

    public NavigationService(Context context)
    {
        _context = context;

        if (!menuItems.Any())
        {
            menuItems = _context.Contents.Where(page => page.IsInMenu.Equals(true) && page.IsPublished.Equals(true)).ToList();
        }

        if (!categoryItems.Any())
        {

            try
            {
                foreach (var category in _context.Categories.Include(a => a.MainCategory).Include(b => b.SubCategory).ToList())
                {
                    if (!categoryItems.Where(x => x.Id.Equals(category.MainCategoryId.ToString())).Any()) //Bewar snälla
                    {
                        List<string> subs = new List<string>();

                        subs.Add(category.SubCategory.Name);

                        CategoryPageModel categoryPage = new CategoryPageModel(category.MainCategoryId.ToString(), category.MainCategory.Name, subs);

                        categoryItems.Add(categoryPage);
                    }
                    else
                    {
                        categoryItems.Where(x => x.Id.Equals(category.MainCategoryId.ToString())).FirstOrDefault().SubCategories.Add(category.SubCategory.Name);

                    }

                }
            }
            catch
            {

            }


        }

        _context.Dispose();

    }

    public List<Content> GetMenu()
    {
        return menuItems;
    }

    public List<CategoryPageModel> GetCategory()
    {
        return categoryItems;
    }

}