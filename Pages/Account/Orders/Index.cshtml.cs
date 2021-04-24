using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameQuest.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace GameQuest.Orders.Pages
{
    [Authorize( Roles = "Admin, Customer, User")]
    public class IndexModel : PageModel
    {
        private readonly Context _context;

        public IndexModel(Context context)
        {
            _context = context;
        }

        public void OnGet()
        {
            GetOrders();
        }

        public List<Order> GetOrders()  
        {
            var result = new List<Order>();

            try
            {
                var user = _context.Users.Where(x => x.UserName == HttpContext.User.Identity.Name).FirstOrDefault();
                result = _context.Orders.Include(y => y.Products).Where(x => x.User == user).ToList();
            }
            catch
            {

                result =  null;
                throw;
            
            }

            return result;

        }

    }
}
