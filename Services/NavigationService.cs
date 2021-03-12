
using GameQuest.Data;
using GameQuest.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

public class NavigationService
{
    private Context _context;

    

    public NavigationService(Context context)
    {
        _context = context;
    }

    public List<Content> GetMenu()
    {
        return _context.Contents.Where(page => page.IsInMenu.Equals(true) && page.IsPublished.Equals(true)).ToList();
    }


    public List<CategoryPageModel> GetCategories()
    {

        List<CategoryPageModel> categoryModel = new List<CategoryPageModel>();

        List<Category> categories = _context.Categories.Include(a => a.MainCategory).Include(b => b.SubCategory).ToList();

        foreach (var category in categories)
        {
            if (!categoryModel.Where(x => x.Id.Equals(category.MainCategoryId.ToString())).Any())
            {

                List<string> subs = new List<string>();

                subs.Add(category.SubCategory.Name);

                CategoryPageModel categoryPage = new CategoryPageModel(category.MainCategoryId.ToString(), category.MainCategory.Name, subs);

                categoryModel.Add(categoryPage);

            }
            else
            {
                categoryModel.Where(x => x.Id.Equals(category.MainCategoryId.ToString())).FirstOrDefault().SubCategories.Add(category.SubCategory.Name);

            }

        }

        return categoryModel;
    }

}