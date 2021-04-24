using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GameQuest.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameQuest.Pages.Cart
{
    [Authorize(Roles = "Customer,User")]
    public class IndexModel : PageModel
    {

        private CartService _cartService;
        private Context _context;

        public bool isSuccess = false;
        public string orderSuccessId = string.Empty;

        public IndexModel(CartService cartService, Context context)
        {
            _cartService = cartService;
            _context = context;
        }

        public void OnGet(string status, string orderid)
        {
            orderSuccessId = orderid;

            if (!string.IsNullOrWhiteSpace(status))
            { 
                if (status.Equals("success"))
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
        }

        public IActionResult OnPostDecrementItem(string productId)
        {
            _cartService.DecrementItem(productId);

            return LocalRedirect("/cart");
        }

        public IActionResult OnPostAddItem(string productId)
        {
            _cartService.AddToCart(productId);

            return LocalRedirect("/cart");
        }

        public IActionResult OnPostRemoveItem(string productId)
        {
            _cartService.RemoveFromCart(productId);

            return LocalRedirect("/cart");
        }

        public IActionResult OnPostAddOrder(string name , string address, string address2, string  district, string zip, string city)
        {

            Order order = new Order();

            User user = _context.Users.Where(user => user.UserName == User.Identity.Name).FirstOrDefault(); // !!

            List<OrderProduct> orderProducts = new List<OrderProduct>();

            _cartService.GetCart().ForEach(item => 
            {
                orderProducts.Add(new OrderProduct {
                
                    OrderId = order.Id,
                    Order = order,
                    ProductId = item.Product.Id.ToString(),
                    ProductName = item.Product.Name,
                    Quantity = item.Quantity,
                    Price = item.Product.Price

                });
            });

            order.Status = "Order Saved";

            order.CustomerName = name;
            order.Address = address;
            order.Address2 = address2;
            order.District = district;
            order.ZipCode = zip;
            order.City = city;

            order.Finished = false;
            order.PaymentMethod = "Not Defined";

            order.UserId = new Guid(user.Id);
            order.User = user;

            order.Products = orderProducts;

            _context.Orders.Add(order);

            _context.SaveChanges();

            isSuccess = true;
            orderSuccessId = order.Id.ToString();

            return LocalRedirect($"/cart/success/{order.Id}");
        }



    }
}
