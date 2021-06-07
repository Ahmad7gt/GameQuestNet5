using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameQuest.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GameQuest.Products.Pages
{
    public class IndexModel : PageModel
    {
        private Context _context;
        private CartService _cartService;

        [BindProperty]
        public List<Product> Products { get; set; }

        public bool isEmpty = false;

        public IndexModel(Context context, CartService cartService)
        {
            _context = context;
            _cartService = cartService;
          

        }

        public void OnGet(string mainCat, string subCat)
        {

            if (string.IsNullOrWhiteSpace(mainCat) && string.IsNullOrWhiteSpace(subCat))
            {
                Products = _context.Products.ToList();
            }
            else
            {
                if (string.IsNullOrWhiteSpace(subCat))
                {
                    Products = _context.Products.Include(a => a.Category.MainCategory).Where(x => x.Category.MainCategory.Name.Equals(mainCat)).ToList();
                }
                else
                {
                    Products = _context.Products.Include(a => a.Category.MainCategory).Include(b => b.Category.SubCategory).Where(x => x.Category.MainCategory.Name.Equals(mainCat) && x.Category.SubCategory.Name.Equals(subCat)).ToList();
                }

            }

            if (!Products.Any())
            {
                isEmpty = true;
            }
            else
            {
                isEmpty = false;
            }
        }


        public IActionResult OnPostAddToCart(string productId)
        {
            _cartService.AddToCart(productId);

            return LocalRedirect("/products");
        }

    }
}
