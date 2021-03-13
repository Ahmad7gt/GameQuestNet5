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
        private readonly ILogger<IndexModel> _logger;

        private Context _context;

        bool isDeals = true;

        public IndexModel(Context context)
        {
            _context = context;
        }
        public List<Product> Products { get; set; }

        public void OnGet()
        {
            Products = _context.Products.Where(x => x.Deals).ToList();

        }
    }
}
