using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameQuest.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameQuest.Pages
{
    public class SearchModel : PageModel
    {

        private Context _context;

        [BindProperty]
        public List<Product> Products { get; set; }

     

        public SearchModel(Context context)
        {
            _context = context;
             
        }
        public void OnGet(string searchQuery)
        {
            if (string.IsNullOrEmpty(searchQuery))
            {

                Products = _context.Products.ToList();
            }
            else
            {
                Products = _context.Products.Where(x => x.Name.Contains(searchQuery) || x.Description.Contains(searchQuery)).ToList();
            }
        }
    }
}
