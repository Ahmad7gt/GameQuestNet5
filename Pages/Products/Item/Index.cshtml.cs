using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameQuest.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameQuest.Pages.Products.Item
{
    public class IndexModel : PageModel
    {
        private readonly Context _context;

        [BindProperty]
        public Product _product { get; set; } = new Product();

        public IndexModel(Context context)
        {
            _context = context;
        }
        public void OnGet(string productId)
        {
            if (!String.IsNullOrWhiteSpace(productId))
            {
                var product = _context.Products.Where(x => x.Id == new Guid(productId)).FirstOrDefault();

                if (product is not null)
                {
                    _product = product;
                }
                else
                {
                    product = null;
                }
            }
        }
    }
}
