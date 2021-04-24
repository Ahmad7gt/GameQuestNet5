using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameQuest.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GameQuest.Pages.Account.Orders
{
    public class DetailsModel : PageModel
    {

        private readonly Context _context;

        [BindProperty]
        public Order _order { get; set; } = new Order();
        public DetailsModel(Context context)
        {
            _context = context;
        }

        public void OnGet(string orderid)
        {
            if (!String.IsNullOrWhiteSpace(orderid))
            {
                _order = _context.Orders.Include(y => y.Products).Where(x => x.Id == new Guid(orderid)).FirstOrDefault();
            }
        }
    }
}
