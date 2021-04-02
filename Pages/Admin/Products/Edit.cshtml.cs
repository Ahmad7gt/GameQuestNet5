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
using Microsoft.EntityFrameworkCore;

namespace GameQuest.Pages.Admin.Products
{
    [Authorize(Roles = "Admin")]
    public class EditModel : PageModel
    {

        public List<MainCategory> MainCategories = new List<MainCategory>();
        public List<SubCategory> SubCategories = new List<SubCategory>();

        [BindProperty]
        public string mainSelectedCategoryItemId { get; set; }
        public List<SelectListItem> MainCategoryItems { set; get; }

        private static string subId;
        private static string mainId;


        [BindProperty]
        public string subSelectedCategoryItemId { get; set; }
        public List<SelectListItem> SubCategoryItems { set; get; }

        private Context _context;

        [BindProperty]
        public Product product { get; set; } = new Product();

        private static Product _p = new Product();

        public EditModel(Context context)
        {
            _context = context;

            MainCategories = _context.MainCategories.ToList();
            SubCategories = _context.SubCategories.ToList();

            MainCategoryItems = new List<SelectListItem>();
            SubCategoryItems = new List<SelectListItem>();
        }

        public void OnGet(string productid)
        {

            product = _context.Products.Include(a => a.Category).Where(x => x.Id == new Guid(productid)).FirstOrDefault();

            _p = product;


            foreach (var mainCat in MainCategories)
            {
                MainCategoryItems.Add(new SelectListItem(mainCat.Name, mainCat.Id.ToString()));   // id visas inte
            }                                                   

            foreach (var mainCat in SubCategories)
            {
                SubCategoryItems.Add(new SelectListItem(mainCat.Name, mainCat.Id.ToString()));          // men Pc har ingen console
            }

            subSelectedCategoryItemId = product.Category.SubCategory.Id.ToString();
            mainSelectedCategoryItemId = product.Category.MainCategory.Id.ToString();

            subId = subSelectedCategoryItemId;
            mainId = mainSelectedCategoryItemId;

        }


        public async Task<IActionResult> OnPostSaveProduct(string name, string description, string imgurl, double price, double sale, string productid)
        {

            try
            {

                Product _product = await _context.Products.Include(a => a.Category).Where(x => x.Id == new Guid(productid)).FirstOrDefaultAsync();


                if(_product is null)
                {
                    _product = _p;
                }

                Category category = _context.Categories.Where(x => x.MainCategoryId.Equals(mainId) && x.SubCategoryId.Equals(subId)).FirstOrDefault();

                
            

            if (category is null)     
            {
                    mainSelectedCategoryItemId = mainId;
                    subSelectedCategoryItemId = subId;

                category = new Category(mainSelectedCategoryItemId, subSelectedCategoryItemId);
                _context.Categories.Add(category);
                _context.SaveChanges();

            }
            else
            {

                _context.Entry(category).State = EntityState.Modified;
            }

            _product.Name = name;
            _product.Description = description;
            _product.ImgUrl = imgurl;
            _product.Price = price;
            _product.Sale = sale;
            _product.IsVisible = true;
            _product.CategoryId = category.Id;
            _product.Category = category;
            _product.Deals = false;



            
                _context.Entry(_product).State = EntityState.Modified;

                _context.Products.Update(_product);

                _context.SaveChanges();

                ViewData["message"] = "You product has been saved";
            }
            catch(Exception ex)
            {
                ViewData["message"] = $"You product was not saved: {ex}";

            }


            return Page();

        }
    }
}
