using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameQuest.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameQuest.Pages
{
    public class ProductsModel : PageModel
    {
        private Context _context;

        [BindProperty]
        public List<Product> Products { get; set; }

        public ProductsModel(Context context)
        {
            _context = context;
            Products = _context.Products.ToList();
        }

        public void OnGet()
        {
         
        }
    }

}
