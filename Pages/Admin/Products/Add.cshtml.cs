using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameQuest.Data;
using GameQuest.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace GameQuest.Pages.Admin.Products
{
    [Authorize(Roles = "Admin")]
    public class AddModel : PageModel
    {

        public List<MainCategory> MainCategories = new List<MainCategory>();
        public List<SubCategory> SubCategories = new List<SubCategory>();

        [BindProperty]
        public string mainSelectedCategoryItemId { get; set; }
        public List<SelectListItem> MainCategoryItems { set; get; }

        [BindProperty]
        public string subSelectedCategoryItemId { get; set; }
        public List<SelectListItem> SubCategoryItems { set; get; }

        private Context _context;

        public AddModel(Context context)
        {
            _context = context;

            MainCategories = _context.MainCategories.ToList();
            SubCategories = _context.SubCategories.ToList();
            MainCategoryItems = new List<SelectListItem>();
            SubCategoryItems = new List<SelectListItem>();
        }

        public void OnGet()
        {

            foreach (var mainCat in MainCategories)
            {
                MainCategoryItems.Add(new SelectListItem(mainCat.Name, mainCat.Id.ToString()));
            }

            foreach (var mainCat in SubCategories)
            {
                SubCategoryItems.Add(new SelectListItem(mainCat.Name, mainCat.Id.ToString()));
            }
        }


        public void OnPostAddProduct(string name, string description, string imgurl, double price, double sale, string mainCategory)
        {

            Category category = _context.Categories.Where(x => x.MainCategoryId.Equals(mainSelectedCategoryItemId.ToString()) && x.SubCategoryId.Equals(subSelectedCategoryItemId.ToString())).FirstOrDefault();

            if (category is null)
            {
                category = new Category(mainSelectedCategoryItemId, subSelectedCategoryItemId);
                _context.Categories.Add(category);
                _context.SaveChanges();

            }

            Product product = new Product
            {
                Name = name,
                Description = description,
                ImgUrl = imgurl,
                Price = price,
                Sale = sale,
                IsVisible = true,
                CategoryId = category.Id,
                Category = category,
                Deals = false
            
            };

            _context.Products.Add(product);
            _context.SaveChanges();

        }
    }
}
