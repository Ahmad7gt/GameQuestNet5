using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace GameQuest.Pages.Cart
{
    public class IndexModel : PageModel
    {

        private CartService _cartService;

        public IndexModel(CartService cartService)
        {
            _cartService = cartService;
        }

        public void OnGet()
        {
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
    }
}
