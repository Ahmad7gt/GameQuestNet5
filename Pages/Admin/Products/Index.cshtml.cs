using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameQuest.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameQuest.Pages.Admin
{
    [Authorize(Roles = "Admin")]
    public class ProductsModel : PageModel
    {

        public List<Product> products;
        public Context _context;

        public ProductsModel(Context context)
        {
            _context = context;
            products = _context.Products.ToList();
        }
        public void OnGet()
        {


        }


        private void ReloadData()
        {
            products = _context.Products.ToList();
        }

        public IActionResult OnPostDeleteProduct(string productid)
        {

            Product product = _context.Products.Where(x => x.Id == new Guid(productid)).FirstOrDefault();

            _context.Products.Remove(product);

            _context.SaveChanges();

            ReloadData();

            return Page();

        }



    }
}
