using GameQuest.Data;
using GameQuest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GameQuest.Pages
{
    public class IndexModel : PageModel
    {
    

        private Context _context;

        bool isDeals = true;
        [BindProperty]
        public List<Product> Products { get; set; }


        public IndexModel(Context context)
        {
            _context = context;
            Products = _context.Products.Where(x => x.Deals.Equals(true)).ToList();
        }
       

        public void OnGet()
        {
            //Products = _context.Products.Where(x => x.Deals).ToList();

        }
    }
}
